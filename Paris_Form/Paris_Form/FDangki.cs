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
    public partial class FDangki : Form
    {
        public FDangki()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                // ấn checkbox thì hiện mật khẩu
                textBox2.UseSystemPasswordChar = false;
                txt_MK.UseSystemPasswordChar = false;
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                // không ấn checkbox thì về dang password
                textBox2.UseSystemPasswordChar = true;
                txt_MK.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conn = @"Data Source=DESKOP-TRUONGNG\SQLEXPRESS;Initial Catalog=BanhKem;User ID=sa;password=sa123";
            string sql = "Insert Into ĐN Values(@TaiKhoan,@MatKhau) ";
            try
            {
                SqlConnection connection = new SqlConnection(conn);
                connection.Open();
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("TaiKhoan", txt_TK.Text);
                command.Parameters.AddWithValue("MatKhau", txt_MK.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR " + ex.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FTrang_chu f = new FTrang_chu();
            this.Hide();
            f.ShowDialog();
        }
    }
}
