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
    public partial class FHoa_don : Form
    {
        public FHoa_don()
        {
            InitializeComponent();
            dgvHD.DataSource = Load_form().Tables["HD"];
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            FTrang_chu f = new FTrang_chu();
            this.Hide();
            f.ShowDialog();
        }

        public DataSet Load_form()
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "select * from HoaDon";
            DataSet dataset = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataset, "HD");
            }
            catch (Exception ex)
            {

                MessageBox.Show("EROR" + ex.Message);
            }
            return dataset;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Insert Into HoaDon Values(@MaHĐ,@MaNV,@MaSP,@MaKH,@SoLuong,@GhiChu,@ThanhTien) ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("MaHĐ", txtMaHD.Text);
                command.Parameters.AddWithValue("MaNV", txtMaNV.Text);
                command.Parameters.AddWithValue("MaSP", txtMaSP.Text);
                command.Parameters.AddWithValue("MaKH", txtMaKH.Text);
                command.Parameters.AddWithValue("SoLuong", txtSoLuong.Text);
                command.Parameters.AddWithValue("GhiChu", txtGhiChu.Text);
                command.Parameters.AddWithValue("ThanhTien", txtTT.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
            dgvHD.DataSource = Load_form().Tables["HD"];
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Update HoaDon Set MaNV = '" + txtMaNV.Text + "',MaSP = '" + txtMaSP.Text + "',MaKH = '" + txtMaKH.Text + "',SoLuong = '" + txtSoLuong.Text + "',GhiChu = '" + txtGhiChu.Text + "',ThanhTien = '" + txtTT.Text + "' where MaHĐ = '" + txtMaHD.Text + "'      ";
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

            dgvHD.DataSource = Load_form().Tables["HD"];
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "DELETE HoaDon where MAHĐ = '" + txtMaHD.Text + "'             ";
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
            dgvHD.DataSource = Load_form().Tables["HD"];
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Select * from HoaDon where MaHĐ = '" + txtMaHD.Text + "'  ";
            DataSet dataSet = new DataSet();
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);
                dataAdapter.Fill(dataSet, "HD1");
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }

            dgvHD.DataSource = dataSet.Tables["HD1"];
            dgvHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FHoa_don_Load(object sender, EventArgs e)
        {

        }
    }
}
