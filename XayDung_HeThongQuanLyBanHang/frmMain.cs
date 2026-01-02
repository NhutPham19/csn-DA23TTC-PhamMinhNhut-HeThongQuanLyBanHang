using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDung_HeThongQuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string TaiKhoanHienTai = "";
        public void HienThiMenu(bool isHienThi)
        {
            // ẩn menu danh mục và nghiệp vụ
            danhMucToolStripMenuItem.Visible = isHienThi; 
            nghiepVuToolStripMenuItem.Visible = isHienThi;
            dangXuatToolStripMenuItem.Visible = isHienThi; // ẩn nút đăng xuất
        }
        private void HienThiFormDangNhap()
        {
            frmDangNhap fLogin = new frmDangNhap();
            fLogin.MdiParent = this;

            fLogin.StartPosition = FormStartPosition.CenterScreen;
            fLogin.Show();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu(false);
            frmDangNhap fLogin = new frmDangNhap();
            fLogin.StartPosition = FormStartPosition.CenterScreen;

            // dừng ch.trình chờ đăng nhập
            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                string quyen = fLogin.quyenHan;
                this.XuLyDangNhapThanhCong(quyen);
            }
            else
            {
                // tắt form
                Application.Exit();
            }
        }

        public void XuLyDangNhapThanhCong(string quyenHan)
        {
            danhMucToolStripMenuItem.Visible = true;
            nghiepVuToolStripMenuItem.Visible = true;

            // x.ly phân quyền
            if (quyenHan == "Admin")
            {
                // mở full quyền cho admin
                dangXuatToolStripMenuItem.Visible = true; // cho đ.xuất
                quanLySanPhamToolStripMenuItem.Visible = true;
                quanLyKhachHangToolStripMenuItem.Visible = true;
                quanLyNhanVienToolStripMenuItem.Visible = true;
                banHangPOSToolStripMenuItem.Visible = true;
                lichSuDonHangToolStripMenuItem.Visible = true;

                this.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG - Xin chào Admin";
            }
            else if (quyenHan == "NhanVien")
            {
                // đc xem
                dangXuatToolStripMenuItem.Visible = true; // cho đ.xuất
                banHangPOSToolStripMenuItem.Visible = true;
                quanLyKhachHangToolStripMenuItem.Visible = true;

                // ẩnx  
                quanLySanPhamToolStripMenuItem.Visible = false;
                quanLyNhanVienToolStripMenuItem.Visible = false;
                lichSuDonHangToolStripMenuItem.Visible = false;

                this.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG - Xin chào Nhân viên";

            }
            if (!KiemTraFormDaMo(typeof(frmBanHang)))
            {
                frmBanHang frmPOS = new frmBanHang();
                frmPOS.MdiParent = this; // Đặt cha là frmMain

                // phóng to
                frmPOS.WindowState = FormWindowState.Maximized;

                frmPOS.Show();
            }
        }
        private bool KiemTraFormDaMo(Type formType)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formType)
                {
                    frm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // đóng tất cả các form đang mở
                foreach (Form child in this.MdiChildren)
                {
                    child.Close();
                }

                //khóa menu về trạng thái chưa đ.nhâp
                danhMucToolStripMenuItem.Visible = false;
                nghiepVuToolStripMenuItem.Visible = false;
                dangXuatToolStripMenuItem.Visible = false;  
                
                this.Text = "HỆ THỐNG QUẢN LÝ BÁN HÀNG";

                // hiện lại frm đăng nhap
                frmDangNhap fLogin = new frmDangNhap();
                fLogin.StartPosition = FormStartPosition.CenterScreen;
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    string quyen = fLogin.quyenHan;
                    // lm cho menu d.nhap lai
                    this.XuLyDangNhapThanhCong(quyen);
                }
                else
                {
                    //để trắng màn hình
                }
            }
        }
        private void quanLySanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraFormDaMo(typeof(frmQuanLiSanPham)))
            {
                frmQuanLiSanPham frmQLSP = new frmQuanLiSanPham();
                frmQLSP.MdiParent = this;
                frmQLSP.WindowState = FormWindowState.Maximized;
                frmQLSP.Show();
            }
        }

        private void quanLyKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraFormDaMo(typeof(frmQuanLiKhachHang)))
            {
                frmQuanLiKhachHang frmQLKH = new frmQuanLiKhachHang();
                frmQLKH.MdiParent = this;
                frmQLKH.WindowState = FormWindowState.Maximized;
                frmQLKH.Show();
            }
        }
        private void quanLyNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraFormDaMo(typeof(frmQuanLyNhanVien)))
            {
                frmQuanLyNhanVien f = new frmQuanLyNhanVien();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }

        private void banHangPOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraFormDaMo(typeof(frmBanHang)))
            {
                frmBanHang frmPOS = new frmBanHang();
                frmPOS.MdiParent = this;
                frmPOS.WindowState = FormWindowState.Maximized;
                frmPOS.Show();
            }
        }

        private void lichSuDonHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!KiemTraFormDaMo(typeof(frmLichSuDonHang)))
            {
                frmLichSuDonHang frmLichSu = new frmLichSuDonHang();
                frmLichSu.MdiParent = this;
                frmLichSu.WindowState = FormWindowState.Maximized;
                frmLichSu.Show();
            }
        }
        private void doiMatKhauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMatKhau = new frmDoiMatKhau();
            doiMatKhau.StartPosition = FormStartPosition.CenterScreen;
            doiMatKhau.ShowDialog();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void nghiệpVụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
