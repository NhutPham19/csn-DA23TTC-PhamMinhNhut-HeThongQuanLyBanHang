using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // thư viện ktra chuỗi (ktra tên đ.nhap)
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDung_HeThongQuanLyBanHang
{
    public partial class frmQuanLyNhanVien : Form
    {
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }
        XuLyNhanVien xuLy = new XuLyNhanVien();
        private void TaiDuLieu()
        {
            dgvNhanVien.DataSource = xuLy.LayDanhSachNhanVien();
            txtTaiKhoan.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            cbQuyen.SelectedIndex = 1;
            txtTaiKhoan.Enabled = true;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex]; 

                txtTaiKhoan.Text = row.Cells["TenDangNhap"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtSDT.Text = row.Cells["SoDienThoai"].Value.ToString();
                cbQuyen.Text = row.Cells["Quyen"].Value.ToString();

                txtTaiKhoan.Enabled = false;
            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {

        }
        private void btnNhapMoi_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            cbQuyen.SelectedIndex = 1;

            txtTaiKhoan.Enabled = true;
        }

        private void frmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            dgvNhanVien.RowTemplate.Height = 40;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtTaiKhoan.Text.Trim(); // trim để xóa khoảng trắng

            // ktra rỗng
            if (taiKhoan == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }
            
            if (!Regex.IsMatch(taiKhoan, "^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Tên tài khoản không hợp lệ!\n- Không được có dấu tiếng Việt\n- Không được có khoảng trắng\n- Không được có ký tự đặc biệt",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }

            if (xuLy.ThemNhanVien(taiKhoan, txtHoTen.Text, txtSDT.Text, cbQuyen.Text))
            {
                MessageBox.Show("Thêm nhân viên thành công! Mật khẩu mặc định là 123");
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Thêm thất bại! Tài khoản có thể đã tồn tại.");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Enabled == true) { MessageBox.Show("Vui lòng chọn nhân viên để sửa!"); return; }

            if (xuLy.SuaNhanVien(txtTaiKhoan.Text, txtHoTen.Text, txtSDT.Text, cbQuyen.Text))
            {
                MessageBox.Show("Sửa thông tin thành công!");
                TaiDuLieu();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string user = txtTaiKhoan.Text;

            // ko thể xóa chính mình nếu đăng nhập
            if (user == frmMain.TaiKhoanHienTai)
            {
                MessageBox.Show("Bạn không thể tự xóa chính mình!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (xuLy.XoaNhanVien(user))
                {
                    MessageBox.Show("Xóa thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! (Không thể xóa Admin gốc)");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Enabled == true) { MessageBox.Show("Vui lòng chọn nhân viên cần reset mật khẩu!"); return; }

            if (MessageBox.Show("Mật khẩu sẽ được đặt lại thành '123'. Tiếp tục?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (xuLy.ResetMatKhau(txtTaiKhoan.Text))
                {
                    MessageBox.Show("Đã reset mật khẩu thành công!");
                }
            }
        }

        private void btnNhapMoi_Click_1(object sender, EventArgs e)
        {

        }
    }
}
