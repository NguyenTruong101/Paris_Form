using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Paris_Form
{
    public partial class FThem_HD : Form
    {
        public FThem_HD()
        {
            InitializeComponent();
        }

        private void FThem_HD_Load(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;Persist Security Info=True;User ID=sa,password=sa123";
            string sql = "Select * from SanPham";
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FTrang_chu f = new FTrang_chu();
            this.Hide();
            f.ShowDialog();
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
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
                MessageBox.Show("Tạo hóa đơn thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FHoa_don f = new FHoa_don();
                this.Hide();
                f.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
                MessageBox.Show("Tạo hóa đơn thất Bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
