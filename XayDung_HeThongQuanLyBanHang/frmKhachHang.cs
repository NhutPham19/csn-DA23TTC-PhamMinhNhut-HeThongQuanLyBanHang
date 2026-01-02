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
    public partial class frmQuanLiKhachHang : Form
    {
        XuLyKhachHang bll_KhachHang = new XuLyKhachHang();
        private int maKHHienTai = 0;
        public frmQuanLiKhachHang()
        {
            InitializeComponent();
        }
        
        private void TaiDuLieu()
        {
            dgvKhachHang.DataSource = bll_KhachHang.LayDanhSachKhachHang();
            tbTenKH.Text = "";
            tbSdt.Text = "";
            tbDiaChi.Text = "";
            maKHHienTai = 0;
        }
        

        private void frmQuanLiKhachHang_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            dgvKhachHang.RowTemplate.Height = 40;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string ten = tbTenKH.Text;
                string sdt = tbSdt.Text;
                string diaChi = tbDiaChi.Text;

                if (string.IsNullOrWhiteSpace(ten))
                {
                    MessageBox.Show("Tên khách hàng không được để trống!");
                    return;
                }

                if (bll_KhachHang.ThemKhachHang(ten, sdt, diaChi))
                {
                    MessageBox.Show("Thêm khách hàng thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                maKHHienTai = Convert.ToInt32(row.Cells["MaKH"].Value);
                tbTenKH.Text = row.Cells["HoTen"].Value.ToString();
                tbSdt.Text = row.Cells["SoDienThoai"].Value.ToString();
                tbDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maKHHienTai == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa!");
                return;
            }

            try
            {
                string ten = tbTenKH.Text;
                string sdt = tbSdt.Text;
                string diaChi = tbDiaChi.Text;

                if (bll_KhachHang.SuaKhachHang(maKHHienTai, ten, sdt, diaChi))
                {
                    MessageBox.Show("Sửa thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maKHHienTai == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa!");
                return;
            }
            if (maKHHienTai == 3)
            {
                MessageBox.Show("Không thể xóa 'Khách vãng lai'!");
                return;
            }

            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (bll_KhachHang.XoaKhachHang(maKHHienTai))
                {
                    MessageBox.Show("Xóa thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! (Có thể do khách hàng này đã có đơn hàng)");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }
    }
}
