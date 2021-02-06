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
    public partial class frm_YazarSil : Form
    {
        public frm_YazarSil()
        {
            InitializeComponent();
        }
        ArrayList yazarIndexes = new ArrayList();
        public frm_Yazarlar frm_Yazarlar;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                int index = Convert.ToInt32(yazarIndexes[Convert.ToInt32(checkedListBox1.CheckedIndices[i].ToString())]);

                SqlCommand sQueryKS = new SqlCommand("Delete From Yazarlar Where YazarID='" + index + "' ", sCon);
                sQueryKS.ExecuteNonQuery();


            }

            checkedListBox1.Items.Clear();

            SqlCommand sQueryK = new SqlCommand("Select YazarID,YazarAdi,YazarSoyadi from Yazarlar", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String yazar = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1);
                    checkedListBox1.Items.Add(yazar, false);
                    yazarIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
            MessageBox.Show("Yazar Silme İşlemi Gerçekleşti.");
            frm_Yazarlar.Yenile();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frm_YazarSil_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryK = new SqlCommand("Select YazarID,YazarAdi,YazarSoyadi from Yazarlar", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String yazar = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1) + " " + sReader.GetString(2);
                    checkedListBox1.Items.Add(yazar, false);
                    yazarIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
            
        }
    }
}
