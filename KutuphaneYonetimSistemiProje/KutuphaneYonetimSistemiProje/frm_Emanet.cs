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
    public partial class frm_Emanet : Form
    {
        public frm_Emanet()
        {
            InitializeComponent();
        }

        private void frm_Emanet_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            DataTable dt = new DataTable();
            //inner join: 
            string sql = "Select E.IslemID,E.EmanetAlanAd,E.EmanetAlanSoyad, E.OduncAlmaTarihi, E.TeslimTarihi, K.KitapAdi,Y.YazarAdi,Y.YazarSoyadi From Emanet E, Kitaplar K,Yazarlar Y Where E.AldigiKitapID = K.KitapID and K.KitapYazarID = Y.YazarID ";
            sCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, sCon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_emanetEkle frm_emanetEkle = new frm_emanetEkle();
            frm_emanetEkle.frm_Emanet = this;
            frm_emanetEkle.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Yenile()
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            DataTable dt = new DataTable();
            //inner join: 
            string sql = "Select E.IslemID,E.EmanetAlanAd,E.EmanetAlanSoyad, E.OduncAlmaTarihi, E.TeslimTarihi, K.KitapAdi,Y.YazarAdi,Y.YazarSoyadi From Emanet E, Kitaplar K,Yazarlar Y Where E.AldigiKitapID = K.KitapID and K.KitapYazarID = Y.YazarID ";
            sCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, sCon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_EmanetSil frm_EmanetSil = new frm_EmanetSil();
            frm_EmanetSil.frm_Emanet = this;
            frm_EmanetSil.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frm_TeslimEtmeyenler frm_TeslimEtmeyenler = new frm_TeslimEtmeyenler();
            frm_TeslimEtmeyenler.frm_Emanet = this;
            frm_TeslimEtmeyenler.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Yenile();
        }
    }
}
