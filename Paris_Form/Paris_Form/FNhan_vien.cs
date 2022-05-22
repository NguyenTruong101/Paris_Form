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
    public partial class FNhan_vien : Form
    {
        public FNhan_vien()
        {
            InitializeComponent();
            dgvNV.DataSource = Load_form().Tables["NV"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FTrang_chu f = new FTrang_chu();
            this.Hide();
            f.ShowDialog();
        }
        public DataSet Load_form()
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password = sa123 ";
            string sql = "Select * from NhanVien";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "NV");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }
            return dataSet;
        }

        private void FNhan_vien_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Insert Into NhanVien Values(@MaNV,@TenNV,@GT,@NS,@SĐT,@DiaChi) ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                command.Parameters.AddWithValue("TenNV", txtTenNV.Text);
                command.Parameters.AddWithValue("GT", cbGT.Text);
                command.Parameters.AddWithValue("NS", dtpNS.Text);
                command.Parameters.AddWithValue("SĐT", txtSDT.Text);
                command.Parameters.AddWithValue("DiaChi", txtDiaChi.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
            dgvNV.DataSource = Load_form().Tables["NV"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Update NhanVien Set TenNV = N'" + txtTenNV.Text + "',GT = N'" + cbGT.Text + "',NS = '" + dtpNS.Text + "',SĐT = '" + txtSDT.Text + "',ĐiaChi = N'"+ txtDiaChi.Text +"' where MaNV = '" + txtMaNV.Text + "'      ";
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

            dgvNV.DataSource = Load_form().Tables["NV"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "DELETE from NhanVien where MaNV = '" + txtMaNV.Text + "'             ";
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
            dgvNV.DataSource = Load_form().Tables["NV"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Select * from NhanVien where MaNV = '" + txtMaNV.Text + "'  ";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "NV1");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }

            dgvNV.DataSource = dataSet.Tables["NV1"];
            dgvNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
