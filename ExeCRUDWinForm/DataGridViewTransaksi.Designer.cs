namespace ExeCRUDWinForm
{
    partial class DataGridViewTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewTransaksi));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyPerItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalBiayaPerItemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahBayarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahKembaliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglTransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblTransaksiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minimarketDataSet2 = new ExeCRUDWinForm.minimarketDataSet2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_TransaksiTableAdapter = new ExeCRUDWinForm.minimarketDataSet2TableAdapters.Tbl_TransaksiTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaksiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeTransaksiDataGridViewTextBoxColumn,
            this.kodeKasirDataGridViewTextBoxColumn,
            this.kodeBarangDataGridViewTextBoxColumn,
            this.qtyPerItemDataGridViewTextBoxColumn,
            this.totalBiayaPerItemDataGridViewTextBoxColumn,
            this.subTotalHargaDataGridViewTextBoxColumn,
            this.totalHargaDataGridViewTextBoxColumn,
            this.jumlahBayarDataGridViewTextBoxColumn,
            this.jumlahKembaliDataGridViewTextBoxColumn,
            this.tglTransaksiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblTransaksiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1307, 227);
            this.dataGridView1.TabIndex = 4;
            // 
            // kodeTransaksiDataGridViewTextBoxColumn
            // 
            this.kodeTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Kode_Transaksi";
            this.kodeTransaksiDataGridViewTextBoxColumn.HeaderText = "Kode_Transaksi";
            this.kodeTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeTransaksiDataGridViewTextBoxColumn.Name = "kodeTransaksiDataGridViewTextBoxColumn";
            this.kodeTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeKasirDataGridViewTextBoxColumn
            // 
            this.kodeKasirDataGridViewTextBoxColumn.DataPropertyName = "Kode_Kasir";
            this.kodeKasirDataGridViewTextBoxColumn.HeaderText = "Kode_Kasir";
            this.kodeKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeKasirDataGridViewTextBoxColumn.Name = "kodeKasirDataGridViewTextBoxColumn";
            this.kodeKasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // kodeBarangDataGridViewTextBoxColumn
            // 
            this.kodeBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.HeaderText = "Kode_Barang";
            this.kodeBarangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeBarangDataGridViewTextBoxColumn.Name = "kodeBarangDataGridViewTextBoxColumn";
            this.kodeBarangDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyPerItemDataGridViewTextBoxColumn
            // 
            this.qtyPerItemDataGridViewTextBoxColumn.DataPropertyName = "Qty_PerItem";
            this.qtyPerItemDataGridViewTextBoxColumn.HeaderText = "Qty_PerItem";
            this.qtyPerItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyPerItemDataGridViewTextBoxColumn.Name = "qtyPerItemDataGridViewTextBoxColumn";
            this.qtyPerItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalBiayaPerItemDataGridViewTextBoxColumn
            // 
            this.totalBiayaPerItemDataGridViewTextBoxColumn.DataPropertyName = "Total_BiayaPerItem";
            this.totalBiayaPerItemDataGridViewTextBoxColumn.HeaderText = "Total_BiayaPerItem";
            this.totalBiayaPerItemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalBiayaPerItemDataGridViewTextBoxColumn.Name = "totalBiayaPerItemDataGridViewTextBoxColumn";
            this.totalBiayaPerItemDataGridViewTextBoxColumn.Width = 125;
            // 
            // subTotalHargaDataGridViewTextBoxColumn
            // 
            this.subTotalHargaDataGridViewTextBoxColumn.DataPropertyName = "SubTotal_Harga";
            this.subTotalHargaDataGridViewTextBoxColumn.HeaderText = "SubTotal_Harga";
            this.subTotalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subTotalHargaDataGridViewTextBoxColumn.Name = "subTotalHargaDataGridViewTextBoxColumn";
            this.subTotalHargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalHargaDataGridViewTextBoxColumn
            // 
            this.totalHargaDataGridViewTextBoxColumn.DataPropertyName = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.HeaderText = "Total_Harga";
            this.totalHargaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalHargaDataGridViewTextBoxColumn.Name = "totalHargaDataGridViewTextBoxColumn";
            this.totalHargaDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahBayarDataGridViewTextBoxColumn
            // 
            this.jumlahBayarDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Bayar";
            this.jumlahBayarDataGridViewTextBoxColumn.HeaderText = "Jumlah_Bayar";
            this.jumlahBayarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahBayarDataGridViewTextBoxColumn.Name = "jumlahBayarDataGridViewTextBoxColumn";
            this.jumlahBayarDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahKembaliDataGridViewTextBoxColumn
            // 
            this.jumlahKembaliDataGridViewTextBoxColumn.DataPropertyName = "Jumlah_Kembali";
            this.jumlahKembaliDataGridViewTextBoxColumn.HeaderText = "Jumlah_Kembali";
            this.jumlahKembaliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahKembaliDataGridViewTextBoxColumn.Name = "jumlahKembaliDataGridViewTextBoxColumn";
            this.jumlahKembaliDataGridViewTextBoxColumn.Width = 125;
            // 
            // tglTransaksiDataGridViewTextBoxColumn
            // 
            this.tglTransaksiDataGridViewTextBoxColumn.DataPropertyName = "Tgl_Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.HeaderText = "Tgl_Transaksi";
            this.tglTransaksiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tglTransaksiDataGridViewTextBoxColumn.Name = "tglTransaksiDataGridViewTextBoxColumn";
            this.tglTransaksiDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblTransaksiBindingSource
            // 
            this.tblTransaksiBindingSource.DataMember = "Tbl_Transaksi";
            this.tblTransaksiBindingSource.DataSource = this.minimarketDataSet2;
            // 
            // minimarketDataSet2
            // 
            this.minimarketDataSet2.DataSetName = "minimarketDataSet2";
            this.minimarketDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1311, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_TransaksiTableAdapter
            // 
            this.tbl_TransaksiTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 285);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "CRUD";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DataGridViewTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DataGridViewTransaksi";
            this.Text = "DataGridViewTransaksi";
            this.Load += new System.EventHandler(this.DataGridViewTransaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblTransaksiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private minimarketDataSet2 minimarketDataSet2;
        private System.Windows.Forms.BindingSource tblTransaksiBindingSource;
        private minimarketDataSet2TableAdapters.Tbl_TransaksiTableAdapter tbl_TransaksiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyPerItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalBiayaPerItemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahBayarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahKembaliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglTransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}