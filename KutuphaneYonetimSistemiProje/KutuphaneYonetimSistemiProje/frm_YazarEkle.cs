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
    public partial class frm_YazarEkle : Form
    {
        public frm_YazarEkle()
        {
            InitializeComponent();
        }

        public frm_Yazarlar frm_Yazarlar;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            // kitaplar tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand sQuery = new SqlCommand("insert into Yazarlar(YazarAdi,YazarSoyadi) values (@YazarAdi,@YazarSoyadi)", sCon);
            sCon.Open();
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            sQuery.Parameters.AddWithValue("@YazarAdi", txtAd.Text);
            sQuery.Parameters.AddWithValue("@YazarSoyadi", txtSoyad.Text);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            sQuery.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            sCon.Close();
            MessageBox.Show("Yazar Ekleme İşlemi Gerçekleşti.");
            frm_Yazarlar.Yenile();
        }

        private void frm_YazarEkle_Load(object sender, EventArgs e)
        {

        }

        private void txtSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
