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
    public partial class frm_yayinevleri : Form
    {
        public frm_yayinevleri()
        {
            InitializeComponent();
        }

        private void frm_yayinevleri_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            DataTable dt = new DataTable();
            //inner join: 
            string sql = "Select * from Yayinevleri";
            sCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, sCon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            DataTable dt = new DataTable();
            //inner join: 
            string sql = "Select * from Yayinevleri";
            sCon.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, sCon);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_yayineviEkle frm_YayineviEkle = new frm_yayineviEkle();
            frm_YayineviEkle.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_yayineviSil frm_YayineviSil = new frm_yayineviSil();
            frm_YayineviSil.ShowDialog();
        }
    }
}
