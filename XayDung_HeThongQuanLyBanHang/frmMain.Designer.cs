namespace XayDung_HeThongQuanLyBanHang
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.heThongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMucToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiepVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doiMatKhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dangXuatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLySanPhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyKhachHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhanVienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banHangPOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lichSuDonHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(166)))), ((int)(((byte)(223)))));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.heThongToolStripMenuItem,
            this.danhMucToolStripMenuItem,
            this.nghiepVuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(2564, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            this.heThongToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doiMatKhauToolStripMenuItem,
            this.dangXuatToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.heThongToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heThongToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.heThongToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            this.heThongToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
            this.heThongToolStripMenuItem.Size = new System.Drawing.Size(192, 49);
            this.heThongToolStripMenuItem.Text = "Hệ thống ";
            // 
            // danhMucToolStripMenuItem
            // 
            this.danhMucToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLySanPhamToolStripMenuItem,
            this.quanLyKhachHangToolStripMenuItem,
            this.quanLyNhanVienToolStripMenuItem});
            this.danhMucToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhMucToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.danhMucToolStripMenuItem.Name = "danhMucToolStripMenuItem";
            this.danhMucToolStripMenuItem.Size = new System.Drawing.Size(195, 49);
            this.danhMucToolStripMenuItem.Text = "Danh mục";
            this.danhMucToolStripMenuItem.Click += new System.EventHandler(this.danhMụcToolStripMenuItem_Click);
            // 
            // nghiepVuToolStripMenuItem
            // 
            this.nghiepVuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.banHangPOSToolStripMenuItem,
            this.lichSuDonHangToolStripMenuItem});
            this.nghiepVuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nghiepVuToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.nghiepVuToolStripMenuItem.Name = "nghiepVuToolStripMenuItem";
            this.nghiepVuToolStripMenuItem.Size = new System.Drawing.Size(198, 49);
            this.nghiepVuToolStripMenuItem.Text = "Nghiệp vụ";
            this.nghiepVuToolStripMenuItem.Click += new System.EventHandler(this.nghiệpVụToolStripMenuItem_Click);
            // 
            // doiMatKhauToolStripMenuItem
            // 
            this.doiMatKhauToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.icon_doiMK;
            this.doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            this.doiMatKhauToolStripMenuItem.Size = new System.Drawing.Size(353, 54);
            this.doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            this.doiMatKhauToolStripMenuItem.Click += new System.EventHandler(this.doiMatKhauToolStripMenuItem_Click);
            // 
            // dangXuatToolStripMenuItem
            // 
            this.dangXuatToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.icon_dangXuat;
            this.dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            this.dangXuatToolStripMenuItem.Size = new System.Drawing.Size(353, 54);
            this.dangXuatToolStripMenuItem.Text = "Đăng xuất";
            this.dangXuatToolStripMenuItem.Click += new System.EventHandler(this.dangXuatToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.thoatToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.thoatToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Sign_out_squre_fill_2x;
            this.thoatToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(353, 54);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quanLySanPhamToolStripMenuItem
            // 
            this.quanLySanPhamToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Box_alt_fill_2x;
            this.quanLySanPhamToolStripMenuItem.Name = "quanLySanPhamToolStripMenuItem";
            this.quanLySanPhamToolStripMenuItem.Size = new System.Drawing.Size(455, 54);
            this.quanLySanPhamToolStripMenuItem.Text = "Quản lý Sản phẩm";
            this.quanLySanPhamToolStripMenuItem.Click += new System.EventHandler(this.quanLySanPhamToolStripMenuItem_Click);
            // 
            // quanLyKhachHangToolStripMenuItem
            // 
            this.quanLyKhachHangToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.User_fill_2x;
            this.quanLyKhachHangToolStripMenuItem.Name = "quanLyKhachHangToolStripMenuItem";
            this.quanLyKhachHangToolStripMenuItem.Size = new System.Drawing.Size(455, 54);
            this.quanLyKhachHangToolStripMenuItem.Text = "Quản lý Khách hàng";
            this.quanLyKhachHangToolStripMenuItem.Click += new System.EventHandler(this.quanLyKhachHangToolStripMenuItem_Click);
            // 
            // quanLyNhanVienToolStripMenuItem
            // 
            this.quanLyNhanVienToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.icon_qlNvien;
            this.quanLyNhanVienToolStripMenuItem.Name = "quanLyNhanVienToolStripMenuItem";
            this.quanLyNhanVienToolStripMenuItem.Size = new System.Drawing.Size(455, 54);
            this.quanLyNhanVienToolStripMenuItem.Text = "Quản lý Nhân viên";
            this.quanLyNhanVienToolStripMenuItem.Click += new System.EventHandler(this.quanLyNhanVienToolStripMenuItem_Click);
            // 
            // banHangPOSToolStripMenuItem
            // 
            this.banHangPOSToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.icon_shop;
            this.banHangPOSToolStripMenuItem.Name = "banHangPOSToolStripMenuItem";
            this.banHangPOSToolStripMenuItem.Size = new System.Drawing.Size(414, 54);
            this.banHangPOSToolStripMenuItem.Text = "Bán hàng ( POS )";
            this.banHangPOSToolStripMenuItem.Click += new System.EventHandler(this.banHangPOSToolStripMenuItem_Click);
            // 
            // lichSuDonHangToolStripMenuItem
            // 
            this.lichSuDonHangToolStripMenuItem.Image = global::XayDung_HeThongQuanLyBanHang.Properties.Resources.Date_range_fill_2x;
            this.lichSuDonHangToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lichSuDonHangToolStripMenuItem.Name = "lichSuDonHangToolStripMenuItem";
            this.lichSuDonHangToolStripMenuItem.Size = new System.Drawing.Size(414, 54);
            this.lichSuDonHangToolStripMenuItem.Text = "Lịch sử Đơn hàng";
            this.lichSuDonHangToolStripMenuItem.Click += new System.EventHandler(this.lichSuDonHangToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1504);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Menu Quản lí toàn bộ Hệ thống ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem heThongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMucToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLySanPhamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyKhachHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nghiepVuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banHangPOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lichSuDonHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dangXuatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhanVienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doiMatKhauToolStripMenuItem;
    }
}