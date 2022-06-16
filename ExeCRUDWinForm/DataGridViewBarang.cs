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
    public partial class DataGridViewBarang : Form
    {
        public DataGridViewBarang()
        {
            InitializeComponent();
        }

        private void DataGridViewBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minimarketDataSet1.Tbl_Barang' table. You can move, or remove it, as needed.
            this.tbl_BarangTableAdapter.Fill(this.minimarketDataSet1.Tbl_Barang);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CRUDBarang().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
