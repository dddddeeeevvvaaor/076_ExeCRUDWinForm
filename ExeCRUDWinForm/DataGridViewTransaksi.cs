using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class DataGridViewTransaksi : Form
    {
        public DataGridViewTransaksi()
        {
            InitializeComponent();
        }

        private void DataGridViewTransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minimarketDataSet2.Tbl_Transaksi' table. You can move, or remove it, as needed.
            this.tbl_TransaksiTableAdapter.Fill(this.minimarketDataSet2.Tbl_Transaksi);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CRUDTransaksi().Show();
            this.Hide();
        }
    }
}
