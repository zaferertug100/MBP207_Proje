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
    public partial class frm_EmanetSil : Form
    {
        public frm_EmanetSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                int index = Convert.ToInt32(emanetIndexes[Convert.ToInt32(checkedListBox1.CheckedIndices[i].ToString())]);

                SqlCommand sQueryKS = new SqlCommand("Delete From Emanet Where IslemID='" + index + "' ", sCon);
                sQueryKS.ExecuteNonQuery();


            }

            checkedListBox1.Items.Clear();

           
            SqlCommand sQueryK = new SqlCommand("Select IslemID,EmanetAlanAd,EmanetAlanSoyad,TeslimTarihi from Emanet", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String emanet = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1) + " " + sReader.GetString(2) + " " + sReader.GetDateTime(3);
                    checkedListBox1.Items.Add(emanet, false);
                    emanetIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
            MessageBox.Show("Emanet Silme İşlemi Gerçekleşti.");
            frm_Emanet.Yenile();
        }

        ArrayList emanetIndexes = new ArrayList();
        public frm_Emanet frm_Emanet;

        private void frm_EmanetSil_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryK = new SqlCommand("Select IslemID,EmanetAlanAd,EmanetAlanSoyad,TeslimTarihi from Emanet", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String emanet = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1) + " " + sReader.GetString(2) + " " + sReader.GetDateTime(3);
                    checkedListBox1.Items.Add(emanet, false);
                    emanetIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
