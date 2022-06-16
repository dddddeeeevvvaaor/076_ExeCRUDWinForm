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
    public partial class CRUDTransaksi : Form
    {
        public CRUDTransaksi()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("");
        private void cmdAdd_Click(object sender, EventArgs e)
        {
            int Kode_Transaksi = int.Parse(TKT.Text);
            int Jumlah_Peritem = int.Parse(TJPI.Text);
            int Total_Bayar_Peritem = int.Parse(TTBPI.Text);
            int Sub_Total = int.Parse(TST.Text);
            int Total_Harga = int.Parse(TTH.Text);
            int Jumlah_Bayar = int.Parse(TJB.Text);
            int Jumlah_Kembali = int.Parse(TJK.Text);
            DateTime Tanggal_Transaksi = DateTime.Parse(TST.Text);
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

        private void CRUDTransaksi_Load(object sender, EventArgs e)
        {
            GetList();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //save
            int Kode_Transaksi = int.Parse(TKT.Text);
            int Jumlah_Peritem = int.Parse(TJPI.Text);
            int Total_Bayar_Peritem = int.Parse(TTBPI.Text);
            int Sub_Total = int.Parse(TST.Text);
            int Total_Harga = int.Parse(TTH.Text);
            int Jumlah_Bayar = int.Parse(TJB.Text);
            int Jumlah_Kembali = int.Parse(TJK.Text);
            DateTime Tanggal_Transaksi = DateTime.Parse(TST.Text);
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
                int Kode_Transaksi = int.Parse(TKT.Text);
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
            int Kode_Transaksi = int.Parse(TKT.Text);
            MessageBox.Show("Successfully Delete...");
            GetList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new DataGridViewTransaksi().Show();
            this.Hide();
        }
    }
}
