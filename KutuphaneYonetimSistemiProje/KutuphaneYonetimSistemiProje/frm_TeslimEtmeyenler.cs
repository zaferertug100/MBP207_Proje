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
    public partial class frm_TeslimEtmeyenler : Form
    {
        public frm_TeslimEtmeyenler()
        {
            InitializeComponent();
        }

        public frm_Emanet frm_Emanet;

        private void frm_TeslimEtmeyenler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'kutuphaneYonetimSistemiDataSet1.Emanet' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.emanetTableAdapter.Fill(this.kutuphaneYonetimSistemiDataSet1.Emanet);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.emanetTableAdapter.FillBy(this.kutuphaneYonetimSistemiDataSet1.Emanet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.emanetTableAdapter.FillBy1(this.kutuphaneYonetimSistemiDataSet1.Emanet);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
