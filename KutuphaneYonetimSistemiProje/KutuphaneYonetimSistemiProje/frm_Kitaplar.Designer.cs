namespace KutuphaneYonetimSistemiProje
{
    partial class frm_Kitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Kitaplar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kitapIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapAciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYazarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapYayineviIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapKategoriIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBasimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapBaskiNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapSayfaSayisiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapDiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitaplarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneYonetimSistemiDataSet = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.kutuphaneYonetimSistemiDataSet1 = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1();
            this.yazarlarTableAdapter = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.YazarlarTableAdapter();
            this.tableAdapterManager = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.TableAdapterManager();
            this.kitaplarTableAdapter = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSetTableAdapters.KitaplarTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.btk_kitapsil = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kitapIDDataGridViewTextBoxColumn,
            this.kitapAdiDataGridViewTextBoxColumn,
            this.kitapAciklamaDataGridViewTextBoxColumn,
            this.kitapYazarIDDataGridViewTextBoxColumn,
            this.kitapYayineviIDDataGridViewTextBoxColumn,
            this.kitapKategoriIDDataGridViewTextBoxColumn,
            this.kitapBasimTarihiDataGridViewTextBoxColumn,
            this.kitapBaskiNoDataGridViewTextBoxColumn,
            this.kitapSayfaSayisiDataGridViewTextBoxColumn,
            this.kitapDiliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kitaplarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(201, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1358, 727);
            this.dataGridView1.TabIndex = 0;
            // 
            // kitapIDDataGridViewTextBoxColumn
            // 
            this.kitapIDDataGridViewTextBoxColumn.DataPropertyName = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.HeaderText = "KitapID";
            this.kitapIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapIDDataGridViewTextBoxColumn.Name = "kitapIDDataGridViewTextBoxColumn";
            this.kitapIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAdiDataGridViewTextBoxColumn
            // 
            this.kitapAdiDataGridViewTextBoxColumn.DataPropertyName = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.HeaderText = "KitapAdi";
            this.kitapAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAdiDataGridViewTextBoxColumn.Name = "kitapAdiDataGridViewTextBoxColumn";
            this.kitapAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapAciklamaDataGridViewTextBoxColumn
            // 
            this.kitapAciklamaDataGridViewTextBoxColumn.DataPropertyName = "KitapAciklama";
            this.kitapAciklamaDataGridViewTextBoxColumn.HeaderText = "KitapAciklama";
            this.kitapAciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapAciklamaDataGridViewTextBoxColumn.Name = "kitapAciklamaDataGridViewTextBoxColumn";
            this.kitapAciklamaDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapAciklamaDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYazarIDDataGridViewTextBoxColumn
            // 
            this.kitapYazarIDDataGridViewTextBoxColumn.DataPropertyName = "KitapYazarID";
            this.kitapYazarIDDataGridViewTextBoxColumn.HeaderText = "KitapYazarID";
            this.kitapYazarIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYazarIDDataGridViewTextBoxColumn.Name = "kitapYazarIDDataGridViewTextBoxColumn";
            this.kitapYazarIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapYazarIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapYayineviIDDataGridViewTextBoxColumn
            // 
            this.kitapYayineviIDDataGridViewTextBoxColumn.DataPropertyName = "KitapYayineviID";
            this.kitapYayineviIDDataGridViewTextBoxColumn.HeaderText = "KitapYayineviID";
            this.kitapYayineviIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapYayineviIDDataGridViewTextBoxColumn.Name = "kitapYayineviIDDataGridViewTextBoxColumn";
            this.kitapYayineviIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapYayineviIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapKategoriIDDataGridViewTextBoxColumn
            // 
            this.kitapKategoriIDDataGridViewTextBoxColumn.DataPropertyName = "KitapKategoriID";
            this.kitapKategoriIDDataGridViewTextBoxColumn.HeaderText = "KitapKategoriID";
            this.kitapKategoriIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapKategoriIDDataGridViewTextBoxColumn.Name = "kitapKategoriIDDataGridViewTextBoxColumn";
            this.kitapKategoriIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapKategoriIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBasimTarihiDataGridViewTextBoxColumn
            // 
            this.kitapBasimTarihiDataGridViewTextBoxColumn.DataPropertyName = "KitapBasimTarihi";
            this.kitapBasimTarihiDataGridViewTextBoxColumn.HeaderText = "KitapBasimTarihi";
            this.kitapBasimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapBasimTarihiDataGridViewTextBoxColumn.Name = "kitapBasimTarihiDataGridViewTextBoxColumn";
            this.kitapBasimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapBasimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapBaskiNoDataGridViewTextBoxColumn
            // 
            this.kitapBaskiNoDataGridViewTextBoxColumn.DataPropertyName = "KitapBaskiNo";
            this.kitapBaskiNoDataGridViewTextBoxColumn.HeaderText = "KitapBaskiNo";
            this.kitapBaskiNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapBaskiNoDataGridViewTextBoxColumn.Name = "kitapBaskiNoDataGridViewTextBoxColumn";
            this.kitapBaskiNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapBaskiNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapSayfaSayisiDataGridViewTextBoxColumn
            // 
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.DataPropertyName = "KitapSayfaSayisi";
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.HeaderText = "KitapSayfaSayisi";
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.Name = "kitapSayfaSayisiDataGridViewTextBoxColumn";
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapSayfaSayisiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitapDiliDataGridViewTextBoxColumn
            // 
            this.kitapDiliDataGridViewTextBoxColumn.DataPropertyName = "KitapDili";
            this.kitapDiliDataGridViewTextBoxColumn.HeaderText = "KitapDili";
            this.kitapDiliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kitapDiliDataGridViewTextBoxColumn.Name = "kitapDiliDataGridViewTextBoxColumn";
            this.kitapDiliDataGridViewTextBoxColumn.ReadOnly = true;
            this.kitapDiliDataGridViewTextBoxColumn.Width = 125;
            // 
            // kitaplarBindingSource
            // 
            this.kitaplarBindingSource.DataMember = "Kitaplar";
            this.kitaplarBindingSource.DataSource = this.kutuphaneYonetimSistemiDataSet;
            // 
            // kutuphaneYonetimSistemiDataSet
            // 
            this.kutuphaneYonetimSistemiDataSet.DataSetName = "KutuphaneYonetimSistemiDataSet";
            this.kutuphaneYonetimSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 189);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kitap Ekle";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kutuphaneYonetimSistemiDataSet1
            // 
            this.kutuphaneYonetimSistemiDataSet1.DataSetName = "KutuphaneYonetimSistemiDataSet1";
            this.kutuphaneYonetimSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // yazarlarTableAdapter
            // 
            this.yazarlarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmanetTableAdapter = null;
            this.tableAdapterManager.KategorilerTableAdapter = null;
            this.tableAdapterManager.KitaplarTableAdapter = null;
            this.tableAdapterManager.KullanicilarTableAdapter = null;
            this.tableAdapterManager.OkurlarTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.YayinevleriTableAdapter = null;
            this.tableAdapterManager.YazarlarTableAdapter = this.yazarlarTableAdapter;
            this.tableAdapterManager.YoneticilerTableAdapter = null;
            // 
            // kitaplarTableAdapter
            // 
            this.kitaplarTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(1423, 763);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 53);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yenile";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btk_kitapsil
            // 
            this.btk_kitapsil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btk_kitapsil.Image = ((System.Drawing.Image)(resources.GetObject("btk_kitapsil.Image")));
            this.btk_kitapsil.Location = new System.Drawing.Point(12, 225);
            this.btk_kitapsil.Name = "btk_kitapsil";
            this.btk_kitapsil.Size = new System.Drawing.Size(183, 189);
            this.btk_kitapsil.TabIndex = 3;
            this.btk_kitapsil.Text = "Kitap Sil";
            this.btk_kitapsil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btk_kitapsil.UseVisualStyleBackColor = true;
            this.btk_kitapsil.Click += new System.EventHandler(this.btk_kitapsil_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(12, 420);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 189);
            this.button3.TabIndex = 4;
            this.button3.Text = "Kitap Düzenle";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(201, 763);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 53);
            this.button4.TabIndex = 5;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm_Kitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1571, 825);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btk_kitapsil);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Kitaplar";
            this.Text = "frm_Kitaplar";
            this.Load += new System.EventHandler(this.frm_Kitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private KutuphaneYonetimSistemiDataSet kutuphaneYonetimSistemiDataSet;
        private System.Windows.Forms.BindingSource kitaplarBindingSource;
        private KutuphaneYonetimSistemiDataSetTableAdapters.KitaplarTableAdapter kitaplarTableAdapter;
        private System.Windows.Forms.Button button1;
        private KutuphaneYonetimSistemiDataSet1 kutuphaneYonetimSistemiDataSet1;
        private KutuphaneYonetimSistemiDataSet1TableAdapters.YazarlarTableAdapter yazarlarTableAdapter;
        private KutuphaneYonetimSistemiDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapAciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYazarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapYayineviIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapKategoriIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBasimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapBaskiNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapSayfaSayisiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapDiliDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btk_kitapsil;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}