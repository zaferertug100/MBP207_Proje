namespace KutuphaneYonetimSistemiProje
{
    partial class frm_KitapDuzenle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDil = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSayfa = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBaskiNo = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBaskiTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYayin = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kutuphaneYonetimSistemiDataSet1 = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1();
            this.kategorilerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kategorilerTableAdapter = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.KategorilerTableAdapter();
            this.kutuphaneYonetimSistemiDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yazarlarTableAdapter = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.YazarlarTableAdapter();
            this.yayinevleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yayinevleriTableAdapter = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.YayinevleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.txtSayfa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaskiNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinevleriBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(391, 128);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(340, 272);
            this.txtAciklama.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(388, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Kitap Açıklama : ";
            // 
            // txtDil
            // 
            this.txtDil.Location = new System.Drawing.Point(157, 383);
            this.txtDil.Name = "txtDil";
            this.txtDil.Size = new System.Drawing.Size(213, 22);
            this.txtDil.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(32, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Kitap Dili : ";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(157, 340);
            this.txtSayfa.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtSayfa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(120, 22);
            this.txtSayfa.TabIndex = 38;
            this.txtSayfa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(32, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Sayfa Sayısı : ";
            // 
            // txtBaskiNo
            // 
            this.txtBaskiNo.Location = new System.Drawing.Point(157, 304);
            this.txtBaskiNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtBaskiNo.Name = "txtBaskiNo";
            this.txtBaskiNo.Size = new System.Drawing.Size(120, 22);
            this.txtBaskiNo.TabIndex = 36;
            this.txtBaskiNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Baskı No : ";
            // 
            // txtBaskiTarihi
            // 
            this.txtBaskiTarihi.Location = new System.Drawing.Point(157, 264);
            this.txtBaskiTarihi.Name = "txtBaskiTarihi";
            this.txtBaskiTarihi.Size = new System.Drawing.Size(213, 22);
            this.txtBaskiTarihi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Basım Tarihi : ";
            // 
            // txtYayin
            // 
            this.txtYayin.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.yayinevleriBindingSource, "YayineviID", true));
            this.txtYayin.DataSource = this.yayinevleriBindingSource;
            this.txtYayin.DisplayMember = "YayineviAdi";
            this.txtYayin.FormattingEnabled = true;
            this.txtYayin.Location = new System.Drawing.Point(157, 216);
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(213, 24);
            this.txtYayin.TabIndex = 32;
            this.txtYayin.ValueMember = "YayineviID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(32, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Yayınevi : ";
            // 
            // txtKat
            // 
            this.txtKat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategorilerBindingSource, "KategoriID", true));
            this.txtKat.DataSource = this.kategorilerBindingSource;
            this.txtKat.DisplayMember = "KategoriAdi";
            this.txtKat.FormattingEnabled = true;
            this.txtKat.Location = new System.Drawing.Point(157, 136);
            this.txtKat.Name = "txtKat";
            this.txtKat.Size = new System.Drawing.Size(213, 24);
            this.txtKat.TabIndex = 30;
            this.txtKat.ValueMember = "KategoriID";
            this.txtKat.SelectedIndexChanged += new System.EventHandler(this.txtKat_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(32, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 29;
            this.label3.Text = "Kategori :";
            // 
            // txtYazar
            // 
            this.txtYazar.FormattingEnabled = true;
            this.txtYazar.Location = new System.Drawing.Point(157, 175);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(213, 24);
            this.txtYazar.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(32, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Yazar : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Kitap Adı :";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(157, 104);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(213, 22);
            this.txtAd.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(548, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 49);
            this.button1.TabIndex = 24;
            this.button1.Text = "Kitap Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(696, 24);
            this.comboBox1.TabIndex = 43;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(32, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 17);
            this.label10.TabIndex = 44;
            this.label10.Text = "Düzenlenecek Kitabı Seçin :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // kutuphaneYonetimSistemiDataSet1
            // 
            this.kutuphaneYonetimSistemiDataSet1.DataSetName = "KutuphaneYonetimSistemiDataSet1";
            this.kutuphaneYonetimSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorilerBindingSource
            // 
            this.kategorilerBindingSource.DataMember = "Kategoriler";
            this.kategorilerBindingSource.DataSource = this.kutuphaneYonetimSistemiDataSet1;
            // 
            // kategorilerTableAdapter
            // 
            this.kategorilerTableAdapter.ClearBeforeFill = true;
            // 
            // kutuphaneYonetimSistemiDataSet1BindingSource
            // 
            this.kutuphaneYonetimSistemiDataSet1BindingSource.DataSource = this.kutuphaneYonetimSistemiDataSet1;
            this.kutuphaneYonetimSistemiDataSet1BindingSource.Position = 0;
            // 
            // yazarlarBindingSource
            // 
            this.yazarlarBindingSource.DataMember = "Yazarlar";
            this.yazarlarBindingSource.DataSource = this.kutuphaneYonetimSistemiDataSet1BindingSource;
            // 
            // yazarlarTableAdapter
            // 
            this.yazarlarTableAdapter.ClearBeforeFill = true;
            // 
            // yayinevleriBindingSource
            // 
            this.yayinevleriBindingSource.DataMember = "Yayinevleri";
            this.yayinevleriBindingSource.DataSource = this.kutuphaneYonetimSistemiDataSet1;
            // 
            // yayinevleriTableAdapter
            // 
            this.yayinevleriTableAdapter.ClearBeforeFill = true;
            // 
            // frm_KitapDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 497);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDil);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSayfa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBaskiNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBaskiTarihi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYayin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.button1);
            this.Name = "frm_KitapDuzenle";
            this.Text = "frm_KitapDuzenle";
            this.Load += new System.EventHandler(this.frm_KitapDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSayfa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaskiNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorilerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yazarlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yayinevleriBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDil;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown txtSayfa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtBaskiNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker txtBaskiTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtYayin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox txtKat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtYazar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private KutuphaneYonetimSistemiDataSet1 kutuphaneYonetimSistemiDataSet1;
        private System.Windows.Forms.BindingSource kategorilerBindingSource;
        private KutuphaneYonetimSistemiDataSet1TableAdapters.KategorilerTableAdapter kategorilerTableAdapter;
        private System.Windows.Forms.BindingSource kutuphaneYonetimSistemiDataSet1BindingSource;
        private System.Windows.Forms.BindingSource yazarlarBindingSource;
        private KutuphaneYonetimSistemiDataSet1TableAdapters.YazarlarTableAdapter yazarlarTableAdapter;
        private System.Windows.Forms.BindingSource yayinevleriBindingSource;
        private KutuphaneYonetimSistemiDataSet1TableAdapters.YayinevleriTableAdapter yayinevleriTableAdapter;
    }
}