namespace KutuphaneYonetimSistemiProje
{
    partial class frm_TeslimEtmeyenler
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emanetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kutuphaneYonetimSistemiDataSet1 = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1();
            this.emanetTableAdapter = new KutuphaneYonetimSistemiProje.KutuphaneYonetimSistemiDataSet1TableAdapters.EmanetTableAdapter();
            this.emanetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ıslemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oduncAlmaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslimEttiMiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıslemIDDataGridViewTextBoxColumn,
            this.oduncAlmaTarihiDataGridViewTextBoxColumn,
            this.teslimTarihiDataGridViewTextBoxColumn,
            this.teslimEttiMiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.emanetBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(808, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // emanetBindingSource
            // 
            this.emanetBindingSource.DataMember = "Emanet";
            this.emanetBindingSource.DataSource = this.kutuphaneYonetimSistemiDataSet1;
            // 
            // kutuphaneYonetimSistemiDataSet1
            // 
            this.kutuphaneYonetimSistemiDataSet1.DataSetName = "KutuphaneYonetimSistemiDataSet1";
            this.kutuphaneYonetimSistemiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emanetTableAdapter
            // 
            this.emanetTableAdapter.ClearBeforeFill = true;
            // 
            // emanetBindingSource1
            // 
            this.emanetBindingSource1.DataMember = "Emanet";
            this.emanetBindingSource1.DataSource = this.kutuphaneYonetimSistemiDataSet1;
            // 
            // ıslemIDDataGridViewTextBoxColumn
            // 
            this.ıslemIDDataGridViewTextBoxColumn.DataPropertyName = "IslemID";
            this.ıslemIDDataGridViewTextBoxColumn.HeaderText = "IslemID";
            this.ıslemIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıslemIDDataGridViewTextBoxColumn.Name = "ıslemIDDataGridViewTextBoxColumn";
            this.ıslemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıslemIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // oduncAlmaTarihiDataGridViewTextBoxColumn
            // 
            this.oduncAlmaTarihiDataGridViewTextBoxColumn.DataPropertyName = "OduncAlmaTarihi";
            this.oduncAlmaTarihiDataGridViewTextBoxColumn.HeaderText = "OduncAlmaTarihi";
            this.oduncAlmaTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oduncAlmaTarihiDataGridViewTextBoxColumn.Name = "oduncAlmaTarihiDataGridViewTextBoxColumn";
            this.oduncAlmaTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.oduncAlmaTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // teslimTarihiDataGridViewTextBoxColumn
            // 
            this.teslimTarihiDataGridViewTextBoxColumn.DataPropertyName = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.HeaderText = "TeslimTarihi";
            this.teslimTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teslimTarihiDataGridViewTextBoxColumn.Name = "teslimTarihiDataGridViewTextBoxColumn";
            this.teslimTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.teslimTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // teslimEttiMiDataGridViewTextBoxColumn
            // 
            this.teslimEttiMiDataGridViewTextBoxColumn.DataPropertyName = "TeslimEttiMi";
            this.teslimEttiMiDataGridViewTextBoxColumn.HeaderText = "TeslimEttiMi";
            this.teslimEttiMiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.teslimEttiMiDataGridViewTextBoxColumn.Name = "teslimEttiMiDataGridViewTextBoxColumn";
            this.teslimEttiMiDataGridViewTextBoxColumn.ReadOnly = true;
            this.teslimEttiMiDataGridViewTextBoxColumn.Width = 125;
            // 
            // frm_TeslimEtmeyenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_TeslimEtmeyenler";
            this.Text = "frm_TeslimEtmeyenler";
            this.Load += new System.EventHandler(this.frm_TeslimEtmeyenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kutuphaneYonetimSistemiDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emanetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private KutuphaneYonetimSistemiDataSet1 kutuphaneYonetimSistemiDataSet1;
        private System.Windows.Forms.BindingSource emanetBindingSource;
        private KutuphaneYonetimSistemiDataSet1TableAdapters.EmanetTableAdapter emanetTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oduncAlmaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslimEttiMiDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource emanetBindingSource1;
    }
}