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
    public partial class DataGridViewKasir : Form
    {
        public DataGridViewKasir()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'minimarketDataSet.Tbl_Kasir' table. You can move, or remove it, as needed.
            this.tbl_KasirTableAdapter.Fill(this.minimarketDataSet.Tbl_Kasir);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CRUDKasir().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }
    }
}
