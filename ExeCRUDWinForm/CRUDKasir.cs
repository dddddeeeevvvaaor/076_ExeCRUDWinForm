using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeCRUDWinForm
{
    public partial class CRUDKasir : Form
    {
        public CRUDKasir()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("");
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int Kode_Kasir = int.Parse(KKK.Text);
            string Nama_Barang = KNB.Text;
            con.Open();
            SqlCommand c = new SqlCommand("");
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted...");
            GetList();
        }

        void GetList()
        {
            SqlCommand c = new SqlCommand("");
            SqlDataAdapter sd = new SqlDataAdapter(c);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            DataGridView.DataSource = dt;
        }

        private void CRUDKasir_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //save
            int Kode_Kasir = int.Parse(KKK.Text);
            string Nama_Barang = KNB.Text;
            con.Open();
            SqlCommand c = new SqlCommand("");
            c.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated...");
            GetList();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            //Delete
            if (MessageBox.Show("Are You Sure To Delete?", "Delete Document", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int Kode_Kasir = int.Parse(KKK.Text);
                con.Open();
                SqlCommand c = new SqlCommand("");
                c.ExecuteNonQuery();
                MessageBox.Show("Successfully Delete...");
                GetList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Load
            int Kode_Kasir = int.Parse(KKK.Text);
            MessageBox.Show("Successfully Delete...");
            GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DataGridViewKasir().Show();
            this.Hide();
        }
    }
}
