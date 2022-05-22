
namespace Paris_Form
{
    partial class FTrang_chu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FTrang_chu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngki = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kHÁCHHÀNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSP = new System.Windows.Forms.Button();
            this.btnNV = new System.Windows.Forms.Button();
            this.btnHD = new System.Windows.Forms.Button();
            this.btnĐX = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.chứcNăngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1058, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngki,
            this.đăngXuấtToolStripMenuItem});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(108, 32);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngki
            // 
            this.đăngki.Name = "đăngki";
            this.đăngki.Size = new System.Drawing.Size(187, 32);
            this.đăngki.Text = "Đăng kí";
            this.đăngki.Click += new System.EventHandler(this.đăngki_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(187, 32);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.sảnPhẩmToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.kHÁCHHÀNGToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(93, 32);
            this.chứcNăngToolStripMenuItem.Text = "Quản lý";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.quảnLýToolStripMenuItem.Text = "Nhân viên";
            this.quảnLýToolStripMenuItem.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // kHÁCHHÀNGToolStripMenuItem
            // 
            this.kHÁCHHÀNGToolStripMenuItem.Name = "kHÁCHHÀNGToolStripMenuItem";
            this.kHÁCHHÀNGToolStripMenuItem.Size = new System.Drawing.Size(203, 32);
            this.kHÁCHHÀNGToolStripMenuItem.Text = "Khách Hàng";
            this.kHÁCHHÀNGToolStripMenuItem.Click += new System.EventHandler(this.kHÁCHHÀNGToolStripMenuItem_Click);
            // 
            // btnSP
            // 
            this.btnSP.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSP.Image = global::Paris_Form.Properties.Resources.images;
            this.btnSP.Location = new System.Drawing.Point(35, 106);
            this.btnSP.Name = "btnSP";
            this.btnSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSP.Size = new System.Drawing.Size(204, 174);
            this.btnSP.TabIndex = 1;
            this.btnSP.Text = "QUẢN LÝ SẢN PHẨM";
            this.btnSP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSP.UseVisualStyleBackColor = true;
            this.btnSP.Click += new System.EventHandler(this.btnSP_Click);
            // 
            // btnNV
            // 
            this.btnNV.BackColor = System.Drawing.Color.White;
            this.btnNV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNV.BackgroundImage")));
            this.btnNV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNV.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnNV.Location = new System.Drawing.Point(551, 106);
            this.btnNV.Name = "btnNV";
            this.btnNV.Size = new System.Drawing.Size(212, 174);
            this.btnNV.TabIndex = 2;
            this.btnNV.Text = "QUẢN LÝ NHÂN VIÊN";
            this.btnNV.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNV.UseVisualStyleBackColor = false;
            this.btnNV.Click += new System.EventHandler(this.btnNV_Click);
            // 
            // btnHD
            // 
            this.btnHD.BackColor = System.Drawing.Color.White;
            this.btnHD.BackgroundImage = global::Paris_Form.Properties.Resources.invoice_icon_vector;
            this.btnHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHD.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnHD.Location = new System.Drawing.Point(296, 106);
            this.btnHD.Name = "btnHD";
            this.btnHD.Size = new System.Drawing.Size(217, 174);
            this.btnHD.TabIndex = 3;
            this.btnHD.Text = "QUẢN LÝ HÓA ĐƠN";
            this.btnHD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHD.UseVisualStyleBackColor = false;
            this.btnHD.Click += new System.EventHandler(this.btnHD_Click);
            // 
            // btnĐX
            // 
            this.btnĐX.BackColor = System.Drawing.Color.White;
            this.btnĐX.Location = new System.Drawing.Point(451, 438);
            this.btnĐX.Name = "btnĐX";
            this.btnĐX.Size = new System.Drawing.Size(172, 62);
            this.btnĐX.TabIndex = 4;
            this.btnĐX.Text = "Đăng Xuất";
            this.btnĐX.UseVisualStyleBackColor = false;
            this.btnĐX.Click += new System.EventHandler(this.btnĐX_Click);
            // 
            // btnKH
            // 
            this.btnKH.BackColor = System.Drawing.Color.White;
            this.btnKH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKH.BackgroundImage")));
            this.btnKH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnKH.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.btnKH.Location = new System.Drawing.Point(815, 106);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(211, 174);
            this.btnKH.TabIndex = 5;
            this.btnKH.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.btnKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKH.UseVisualStyleBackColor = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(35, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 149);
            this.button1.TabIndex = 6;
            this.button1.Text = "ĐẶT HÀNG";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FTrang_chu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::Paris_Form.Properties.Resources.foody_upload_api_foody_mobile_cover_200522152648;
            this.ClientSize = new System.Drawing.Size(1058, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKH);
            this.Controls.Add(this.btnĐX);
            this.Controls.Add(this.btnHD);
            this.Controls.Add(this.btnNV);
            this.Controls.Add(this.btnSP);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FTrang_chu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.FTrang_chu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngki;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Button btnSP;
        private System.Windows.Forms.Button btnNV;
        private System.Windows.Forms.Button btnĐX;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.ToolStripMenuItem kHÁCHHÀNGToolStripMenuItem;
        private System.Windows.Forms.Button btnHD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button1;
    }
}