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
    public partial class frmDangNhap : Form
    {
        XuLyNguoiDung bll_NguoiDung = new XuLyNguoiDung();
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string quyenHan = "";
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ten = txtTenDangNhap.Text;
            string mk = txtMatKhau.Text;

            // ktra dlieu từ database
            DataTable dt = bll_NguoiDung.KiemTraDangNhap(ten, mk);

            if (dt.Rows.Count > 0)
            {
                ThongTinNguoiDung.TenDangNhapHienTai = txtTenDangNhap.Text;
                quyenHan = dt.Rows[0]["Quyen"].ToString();
                MessageBox.Show("Đăng nhập thành công!");
                frmMain.TaiKhoanHienTai = txtTenDangNhap.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
