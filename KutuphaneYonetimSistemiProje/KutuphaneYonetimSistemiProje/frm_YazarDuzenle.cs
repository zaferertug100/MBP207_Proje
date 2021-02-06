using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections;

namespace KutuphaneYonetimSistemiProje
{
    public partial class frm_YazarDuzenle : Form
    {
        public frm_YazarDuzenle()
        {
            InitializeComponent();
        }
        public frm_Yazarlar frm_Yazarlar;
        ArrayList yazarIndexes = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");

            int index = Convert.ToInt32(yazarIndexes[Convert.ToInt32(comboBox1.SelectedIndex.ToString())]);
            // kitaplar tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand sQuery = new SqlCommand("Update Yazarlar Set YazarAdi=@YazarAdi, YazarSoyadi=@YazarSoyadi Where YazarID='" + index + "'", sCon);
            sCon.Open();


            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            sQuery.Parameters.AddWithValue("@YazarAdi", txtAd.Text);
            sQuery.Parameters.AddWithValue("@YazarSoyadi", txtSoyad.Text);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            sQuery.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            sCon.Close();
            MessageBox.Show("Yazar Düzenleme İşlemi Gerçekleşti.");
            frm_Yazarlar.Yenile();
        }

        private void frm_YazarDuzenle_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryK = new SqlCommand("Select YazarID,YazarAdi,YazarSoyadi from Yazarlar", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String yazar = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1) +" " + sReader.GetString(2);
                    comboBox1.Items.Add(yazar);
                    yazarIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
        }
    }
}
