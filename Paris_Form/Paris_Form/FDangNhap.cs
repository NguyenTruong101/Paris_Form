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
    public partial class FDangNhap : Form
    {
        public FDangNhap()
        {
            InitializeComponent();
        }
       
            private void cbb_show_CheckedChanged(object sender, EventArgs e)
        {
            if (cbb_show.CheckState == CheckState.Checked)
            {
                // ấn checkbox thì hiện mật khẩu
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else if (cbb_show.CheckState == CheckState.Unchecked)
            {
                // không ấn checkbox thì về dang password
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }
        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            try
            {
                SqlConnection sql = new SqlConnection(conn);

                sql.Open();
                string user = txt_taikhoan.Text;
                string pass = txt_matkhau.Text;
                string query = "Select count(*) from ĐN where TaiKhoan = '" + txt_taikhoan.Text + "' and MatKhau = '" + txt_matkhau.Text + "'";

                SqlCommand cm = new SqlCommand(query, sql);
                cm.Parameters.Add(new SqlParameter("@user", user));
                cm.Parameters.Add(new SqlParameter("@pass", pass));

                int n = (int)cm.ExecuteScalar();
                sql.Close();

                if (n == 1)
                {
                    MessageBox.Show("Đăng Nhập Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FTrang_chu f = new FTrang_chu();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng Nhập Thất Bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR" + ex.Message);
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult tb; // khởi tạo thông báo
            tb = MessageBox.Show("Bạn có muốn thoát khỏi chương trình?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes) // Nếu bấm yes thì chương trình sẽ đóng
                Application.Exit();
        }

        private void FDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}

