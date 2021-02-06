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
    public partial class frm_Kitaplar : Form
    {
        public frm_Kitaplar()
        {
            InitializeComponent();
        }

        private void frm_Kitaplar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet.Kitaplar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kitaplarTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet.Kitaplar);

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.yazarlarTableAdapter.FillBy2(this.kutuphaneYonetimSistemiDataSet1.Yazarlar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kitaplarTableAdapter.FillBy(this.kutuphaneYonetimSistemiDataSet.Kitaplar);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_KitapEkle frm_KitapEkle = new frm_KitapEkle();
            frm_KitapEkle.frm_Kitaplar = this;
            frm_KitapEkle.ShowDialog();
        }

        public void Yenile()
        {

            this.kitaplarTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet.Kitaplar);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Yenile();
        }

        private void btk_kitapsil_Click(object sender, EventArgs e)
        {
            frm_kitapsil frm_kitapsil = new frm_kitapsil();
            frm_kitapsil.frm_Kitaplar = this;
            frm_kitapsil.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_KitapDuzenle frm_KitapDuzenle = new frm_KitapDuzenle();
            frm_KitapDuzenle.frm_Kitaplar = this;
            frm_KitapDuzenle.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
