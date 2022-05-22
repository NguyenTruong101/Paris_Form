using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paris_Form
{
    public partial class FTrang_chu : Form
    {
        public FTrang_chu()
        {
            InitializeComponent();
        }
        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNhan_vien f = new FNhan_vien();
            this.Hide();
            f.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FSan_pham f = new FSan_pham();
            this.Hide();
            f.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FHoa_don f = new FHoa_don();
            this.Hide();
            f.ShowDialog();
        }
        private void kHÁCHHÀNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FKhach_Hang f = new FKhach_Hang();
            this.Hide();
            f.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void đăngki_Click(object sender, EventArgs e)
        {
            FDangki f = new FDangki();
            this.Hide();
            f.ShowDialog();
        }

        private void FTrang_chu_Load(object sender, EventArgs e)
        {

        }

        private void btnĐX_Click(object sender, EventArgs e)
        {
            FDangNhap f = new FDangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            FSan_pham frmSP = new FSan_pham();
            this.Hide();
            frmSP.ShowDialog();
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            FHoa_don frmHD = new FHoa_don();
            this.Hide();
            frmHD.ShowDialog();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            FNhan_vien frmNV = new FNhan_vien();
            this.Hide();
            frmNV.ShowDialog();
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            FKhach_Hang frmKH = new FKhach_Hang();
            this.Hide();
            frmKH.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FThem_HD frmThem = new FThem_HD();
            this.Hide();
            frmThem.ShowDialog();
        }
    }
}
