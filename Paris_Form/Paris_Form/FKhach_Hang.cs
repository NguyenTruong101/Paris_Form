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
    public partial class FKhach_Hang : Form
    {
        public FKhach_Hang()
        {
            InitializeComponent();
            dgvKH.DataSource = Load_form().Tables["KH"];
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public DataSet Load_form()
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa ;password = sa123 ";
            string sql = "Select * from KhachHang";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "KH");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }
            return dataSet;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FKhach_Hang_Load(object sender, EventArgs e)
        {

        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FTrang_chu f = new FTrang_chu();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Insert Into KhachHang Values(@MaKH,@TenKH,@GT,@NS,@SĐT) ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("MaKH", txtMaKH.Text);
                command.Parameters.AddWithValue("TenKH", txtTenKH.Text);
                command.Parameters.AddWithValue("GT", cbGT.Text);
                command.Parameters.AddWithValue("NS", dtpNS.Text);
                command.Parameters.AddWithValue("SĐT", txtSDT.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
            dgvKH.DataSource = Load_form().Tables["KH"];
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Update KhachHang Set TenKH = N'" + txtTenKH.Text + "',GT = N'" + cbGT.Text + "',NS = '" + dtpNS.Text + "',SĐT = '" + txtSDT.Text + "' where MaKH = '" + txtMaKH.Text + "'      ";
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

            dgvKH.DataSource = Load_form().Tables["KH"];
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "DELETE from KhachHang where MaKH = '" + txtMaKH.Text + "'             ";
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
            dgvKH.DataSource = Load_form().Tables["KH"];
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Select * from KhachHang where MaKH = '" + txtMaKH.Text + "'  ";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "KH1");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }

            dgvKH.DataSource = dataSet.Tables["KH1"];
            dgvKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
