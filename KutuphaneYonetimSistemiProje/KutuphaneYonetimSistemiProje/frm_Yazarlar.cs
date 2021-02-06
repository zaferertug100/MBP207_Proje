using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemiProje
{
    public partial class frm_Yazarlar : Form
    {
        public frm_Yazarlar()
        {
            InitializeComponent();
        }

        private void frm_Yazarlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet1.Yazarlar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yazarlarTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet1.Yazarlar);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_YazarEkle frm_YazarEkle = new frm_YazarEkle();
            frm_YazarEkle.frm_Yazarlar = this;
            frm_YazarEkle.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Yenile()
        {

            this.yazarlarTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet1.Yazarlar);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_YazarSil frm_YazarSil = new frm_YazarSil();
            frm_YazarSil.frm_Yazarlar = this;
            frm_YazarSil.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_YazarDuzenle frm_YazarDuzenle = new frm_YazarDuzenle();
            frm_YazarDuzenle.frm_Yazarlar = this;
            frm_YazarDuzenle.ShowDialog();
        }
    }
}
