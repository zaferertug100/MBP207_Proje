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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btk_kitapsil_Click(object sender, EventArgs e)
        {
            
            frm_Kitaplar frm_Kitaplar = new frm_Kitaplar();
            frm_Kitaplar.ShowDialog();
        }

        public frm_giris frm_Giris;
        public string isim = "";
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldin " + isim;
            frm_Giris.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Yazarlar frm_Yazarlar = new frm_Yazarlar();
            frm_Yazarlar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_Emanet frm_Emanet = new frm_Emanet();
            frm_Emanet.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_yayinevleri frm_Yayinevleri = new frm_yayinevleri();
            frm_Yayinevleri.ShowDialog();
        }
    }
}
