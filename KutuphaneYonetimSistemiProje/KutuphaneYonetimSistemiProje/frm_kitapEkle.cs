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
    public partial class frm_KitapEkle : Form
    {
        public frm_Kitaplar frm_Kitaplar;

        public frm_KitapEkle()
        {
            InitializeComponent();
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryY = new SqlCommand("Select YazarAdi+' '+YazarSoyadi from Yazarlar", sCon);
            SqlDataReader sReader = sQueryY.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    txtYazar.Items.Add(sReader.GetString(0));
                }
            }
            txtYazar.SelectedIndex = 0;
            sCon.Close();

        }

        private void frm_kitapEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet11.Yayinevleri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yayinevleriTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet11.Yayinevleri);
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet11.Kategoriler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kategorilerTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet11.Kategoriler);
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet11.Yazarlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazarlarTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet11.Yazarlar);

        }

        private void yazarlarBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yazarlarTableAdapter.FillBy(this.kutuphaneYonetimSistemiDataSet11.Yazarlar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yazarlarTableAdapter.FillBy1(this.kutuphaneYonetimSistemiDataSet11.Yazarlar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            // kitaplar tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
            SqlCommand sQuery = new SqlCommand("insert into kitaplar(KitapAdi,KitapAciklama,KitapYazarID,kitapYayineviID,KitapKategoriID,KitapBasimTarihi,KitapBaskiNo,KitapSayfaSayisi,KitapDili) values (@KitapAdi,@KitapAciklama,@KitapYazarID,@kitapYayineviID,@KitapKategoriID,@KitapBasimTarihi,@KitapBaskiNo,@KitapSayfaSayisi,@KitapDili)", sCon);
            sCon.Open();

            SqlCommand sQueryY = new SqlCommand("Select YazarID from Yazarlar Where YazarAdi+' '+YazarSoyadi='"+txtYazar.Text+"' ", sCon);
            SqlCommand sQueryK = new SqlCommand("Select KategoriID from Kategoriler Where KategoriAdi='"+txtKat.Text+"' ", sCon);
            SqlCommand sQueryE = new SqlCommand("Select YayineviID from Yayinevleri Where YayineviAdi='"+txtYayin.Text+"' ", sCon);

            int yazarID = 0;
            int kategoriID = 0;
            int yayineviID = 0;

            SqlDataReader sReader = sQueryY.ExecuteReader();
            if(sReader.Read())
                yazarID = (sReader.GetInt32(0));
            sReader.Close();

            sReader = sQueryK.ExecuteReader();
            if (sReader.Read())
                kategoriID = (sReader.GetInt32(0));
            sReader.Close();


            sReader = sQueryE.ExecuteReader();
            if (sReader.Read())
                yayineviID = (sReader.GetInt32(0));
            sReader.Close();









            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            sQuery.Parameters.AddWithValue("@KitapAdi", txtAd.Text);
            sQuery.Parameters.AddWithValue("@KitapAciklama", txtAciklama.Text);
            sQuery.Parameters.AddWithValue("@KitapYazarID", yazarID);
            sQuery.Parameters.AddWithValue("@kitapYayineviID", yayineviID);
            sQuery.Parameters.AddWithValue("@KitapKategoriID", kategoriID);
            sQuery.Parameters.AddWithValue("@KitapBasimTarihi", txtBaskiTarihi.Value.ToString());
            sQuery.Parameters.AddWithValue("@KitapBaskiNo", txtBaskiNo.Text);
            sQuery.Parameters.AddWithValue("@KitapSayfaSayisi", txtSayfa.Text);
            sQuery.Parameters.AddWithValue("@KitapDili", txtDil.Text);
            //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
            sQuery.ExecuteNonQuery();
            //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
            sCon.Close();
            MessageBox.Show("Kitap Ekleme İşlemi Gerçekleşti.");
            frm_Kitaplar.Yenile();

        }
    }
}
