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
    public partial class frm_giris : Form
    {
        public frm_giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryY = new SqlCommand("Select YoneticiKullaniciAdi,YoneticiParola,YoneticiAdi from Yoneticiler Where YoneticiKullaniciAdi='"+txtAd.Text+ "' and YoneticiParola='" + txtParola.Text + "' ", sCon);
            SqlDataReader sReader = sQueryY.ExecuteReader();
            if (sReader.HasRows)
            {

                if (sReader.Read())
                {
                    Form1 Form1 = new Form1();
                    Form1.frm_Giris = this;
                    Form1.isim = sReader.GetString(2);
                    Form1.ShowDialog();

                }

            }
            else
            {
                MessageBox.Show("Bilgiler Yanlış");
            }

            sCon.Close();
        }

        private void frm_giris_Load(object sender, EventArgs e)
        {

        }
    }
}
