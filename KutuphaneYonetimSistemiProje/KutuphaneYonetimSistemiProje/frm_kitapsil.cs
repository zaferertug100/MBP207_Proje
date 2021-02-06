﻿using System;
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
    public partial class frm_kitapsil : Form
    {
        public frm_kitapsil()
        {
            InitializeComponent();
        }


        public frm_Kitaplar frm_Kitaplar;
        ArrayList kitapIndexes = new ArrayList();
        private void frm_kitapsil_Load(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();
            SqlCommand sQueryK = new SqlCommand("Select KitapID,KitapAdi from Kitaplar", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String kitap = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1);
                    checkedListBox1.Items.Add(kitap,false);
                    kitapIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sCon = new SqlConnection("Data Source = MSI\\SQLEXPRESS; Initial Catalog = KutuphaneYonetimSistemi; Integrated Security = True");
            sCon.Open();

            for (int i = 0; i < checkedListBox1.CheckedIndices.Count; i++)
            {
                int index = Convert.ToInt32(kitapIndexes[Convert.ToInt32(checkedListBox1.CheckedIndices[i].ToString())]);
                    
                SqlCommand sQueryKS = new SqlCommand("Delete From Kitaplar Where KitapID='"+index+"' ", sCon);
                sQueryKS.ExecuteNonQuery();


            }

            checkedListBox1.Items.Clear();

            SqlCommand sQueryK = new SqlCommand("Select KitapID,KitapAdi from Kitaplar", sCon);
            SqlDataReader sReader = sQueryK.ExecuteReader();
            if (sReader.HasRows)
            {
                while (sReader.Read())
                {
                    String kitap = sReader.GetInt32(0).ToString() + " " + sReader.GetString(1);
                    checkedListBox1.Items.Add(kitap, false);
                    kitapIndexes.Add(sReader.GetInt32(0).ToString());
                }
            }
            sCon.Close();
            MessageBox.Show("Kitap Silme İşlemi Gerçekleşti.");
            frm_Kitaplar.Yenile();
        }
    }
}