namespace ExeCRUDWinForm
{
    partial class DataGridViewKasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGridViewKasir));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKasirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblKasirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minimarketDataSet = new ExeCRUDWinForm.minimarketDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_KasirTableAdapter = new ExeCRUDWinForm.minimarketDataSetTableAdapters.Tbl_KasirTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKasirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet)).BeginInit();
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
            this.kodeKasirDataGridViewTextBoxColumn,
            this.namaKasirDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblKasirBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(304, 221);
            this.dataGridView1.TabIndex = 4;
            // 
            // kodeKasirDataGridViewTextBoxColumn
            // 
            this.kodeKasirDataGridViewTextBoxColumn.DataPropertyName = "Kode_Kasir";
            this.kodeKasirDataGridViewTextBoxColumn.HeaderText = "Kode_Kasir";
            this.kodeKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kodeKasirDataGridViewTextBoxColumn.Name = "kodeKasirDataGridViewTextBoxColumn";
            this.kodeKasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaKasirDataGridViewTextBoxColumn
            // 
            this.namaKasirDataGridViewTextBoxColumn.DataPropertyName = "Nama_Kasir";
            this.namaKasirDataGridViewTextBoxColumn.HeaderText = "Nama_Kasir";
            this.namaKasirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaKasirDataGridViewTextBoxColumn.Name = "namaKasirDataGridViewTextBoxColumn";
            this.namaKasirDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblKasirBindingSource
            // 
            this.tblKasirBindingSource.DataMember = "Tbl_Kasir";
            this.tblKasirBindingSource.DataSource = this.minimarketDataSet;
            // 
            // minimarketDataSet
            // 
            this.minimarketDataSet.DataSetName = "minimarketDataSet";
            this.minimarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_KasirTableAdapter
            // 
            this.tbl_KasirTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 285);
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
            // DataGridViewKasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(331, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DataGridViewKasir";
            this.Text = "DataGridViewKasir";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblKasirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private minimarketDataSet minimarketDataSet;
        private System.Windows.Forms.BindingSource tblKasirBindingSource;
        private minimarketDataSetTableAdapters.Tbl_KasirTableAdapter tbl_KasirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKasirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
    }
}

