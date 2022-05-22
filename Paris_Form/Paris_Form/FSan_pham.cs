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

namespace Paris_Form
{
    public partial class FSan_pham : Form
    {
        public FSan_pham()
        {
            InitializeComponent();
            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            FTrang_chu f = new FTrang_chu();
            this.Hide();
            f.ShowDialog();
        }
        public DataSet Load_form()
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password = sa123 ";
            string sql = "Select * from SanPham";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "SP");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }
            return dataSet;
        }

        private void FSan_pham_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Insert Into SanPham Values(@MaSP,@TenSP,@DonVi,@Gia) ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("MaSP", txtMaSP.Text);
                command.Parameters.AddWithValue("TenSP", txtTenSP.Text);
                command.Parameters.AddWithValue("DonVi", txtDonVi.Text);
                command.Parameters.AddWithValue("Gia", txtGia.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Update SanPham Set TenSP = N'" + txtTenSP.Text + "',DonVi = '" + txtDonVi.Text + "',Gia = '" + txtGia.Text + "' where MaSP = '" + txtMaSP.Text + "'      ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }

            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "DELETE from SanPham where MaSP = '" + txtMaSP.Text + "'             ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }
            dgvSP.DataSource = Load_form().Tables["SP"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Select * from SanPham where MaSP = '" + txtMaSP.Text + "'  ";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "SP1");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }

            dgvSP.DataSource = dataSet.Tables["SP1"];
            dgvSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
