using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KutuphaneYonetimSistemiProje
{
    public partial class frm_emanetEkle : Form
    {
        public frm_emanetEkle()
        {
            InitializeComponent();
        }
        public frm_Emanet frm_Emanet;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            // Emanet tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand sQuery = new SqlCommand("insert into Emanet(OduncAlmaTarihi,TeslimTarihi,TeslimEttiMi,AldigiKitapID,EmanetAlanAd,EmanetAlanSoyad) values (@OduncAlmaTarihi,@TeslimTarihi,@TeslimEttiMi,@AldigiKitapID,@EmanetAlanAd,@EmanetAlanSoyad)", sCon);
            SqlCommand sQueryY = new SqlCommand("Select KitapID from Kitaplar Where KitapAdi= '" + comboBox1.Text + "' ", sCon);

            SqlDataReader sReader = sQueryY.ExecuteReader();
            int kitapID = 0;

            if(sReader.Read())
            {

                kitapID = sReader.GetInt32(0);

            }
            sReader.Close();
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            sQuery.Parameters.AddWithValue("@OduncAlmaTarihi", DateTime.Now);
            sQuery.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker1.Value);
            sQuery.Parameters.AddWithValue("@TeslimEttiMi", false);
            sQuery.Parameters.AddWithValue("@AldigiKitapID", kitapID);
            sQuery.Parameters.AddWithValue("@EmanetAlanAd", txtAd.Text);
            sQuery.Parameters.AddWithValue("@EmanetAlanSoyad", txtSoyad.Text);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            sQuery.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            sCon.Close();
            MessageBox.Show("Emanet Ekleme İşlemi Gerçekleşti.");
            frm_Emanet.Yenile();
        }

        private void frm_emanetEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet1.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet1.Kitaplar);

        }
    }
}
