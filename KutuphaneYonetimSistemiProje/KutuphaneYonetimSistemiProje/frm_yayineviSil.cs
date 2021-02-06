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
using System.Collections;

namespace KutuphaneYonetimSistemiProje
{
    public partial class frm_yayineviSil : Form
    {
        public frm_yayineviSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                int index = Convert.ToInt32(yayineviIndexes[Convert.ToInt32(checkedListBox1.CheckedIndices[i].ToString())]);

                SqlCommand sQueryKS = new SqlCommand("Delete From Yayinevleri Where YayineviID='" + index + "' ", sCon);
                sQueryKS.ExecuteNonQuery();


            }

            checkedListBox1.Items.Clear();


            SqlCommand sQueryK = new SqlCommand("Select YayineviID,YayineviAdi,YayineviAdresi from Yayinevleri", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String yayinevi = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1) + " " + sReader.GetString(2);
                    checkedListBox1.Items.Add(yayinevi, false);
                    yayineviIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
            MessageBox.Show("Yayinevi Silme İşlemi Gerçekleşti.");
        }

        ArrayList yayineviIndexes = new ArrayList();

        private void frm_yayineviSil_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryK = new SqlCommand("Select YayineviID,YayineviAdi,YayineviAdresi from Yayinevleri", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String yayinevi = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1) + " " + sReader.GetString(2);
                    checkedListBox1.Items.Add(yayinevi, false);
                    yayineviIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
        }
    }
}
