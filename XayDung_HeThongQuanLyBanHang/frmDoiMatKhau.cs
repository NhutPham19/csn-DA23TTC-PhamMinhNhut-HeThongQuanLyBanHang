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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        XuLyNhanVien bll = new XuLyNhanVien();

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string mkCu = txtMatKhauCu.Text;
            string mkMoi = txtMatKhauMoi.Text;
            string mkNhapLai = txtNhapLai.Text;

            // lấy tên người đang dùng từ frmMain
            string userDangDung = frmMain.TaiKhoanHienTai;

            // ktra dl đầu vào
            if (mkCu == "" || mkMoi == "" || mkNhapLai == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (mkMoi != mkNhapLai)
            {
                MessageBox.Show("Mật khẩu mới không khớp!");
                return;
            }

            // ktra mk cũ có đúng  k 
            if (bll.KiemTraMatKhauCu(userDangDung, mkCu) == false)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!");
                return;
            }

            // thực hiện đổi mk
            if (bll.DoiMatKhau(userDangDung, mkMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công! Vui lòng đăng nhập lại.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại.");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
