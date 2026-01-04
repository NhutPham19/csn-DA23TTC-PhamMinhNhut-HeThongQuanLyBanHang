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
    public partial class frmQuanLiSanPham : Form
    {
        XuLySanPham xuLy = new XuLySanPham();
        private int maSPHienTai = 0; // biến lưu sp đang được chọn
        public frmQuanLiSanPham()
        {
            InitializeComponent();
        }
        private void TaiDuLieu()
        {
            DataTable dt = xuLy.LayDanhSachSanPham();
            dgvSanPham.DataSource = dt;
            tbTenSP.Text = "";
            tbGia.Text = "";
            tbSoLuong.Text = "";
            tbMoTa.Text = "";
            maSPHienTai = 0;

            if (dgvSanPham.Columns["DaXoa"] != null)
            {
                dgvSanPham.Columns["DaXoa"].Visible = false;
            }
        }
        private void frmQuanLiSanPham_Load(object sender, EventArgs e)
        {
            TaiDuLieu();
            dgvSanPham.RowTemplate.Height = 40;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTenSP.Text)) // ktra rỗng
            {
                MessageBox.Show("Vui lòng nhập Tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbTenSP.Focus();
                return;
            }

            // ktra giá tiền ko âm
            decimal gia;
            if (!decimal.TryParse(tbGia.Text, out gia))
            {
                MessageBox.Show("Giá tiền phải là một con số hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbGia.Focus();
                return;
            }
            if (gia < 0)
            {
                MessageBox.Show("Giá tiền không được nhỏ hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ktra s.lượng k âm
            int soluong;
            if (!int.TryParse(tbSoLuong.Text, out soluong))
            {
                MessageBox.Show("Số lượng phải là số nguyên!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSoLuong.Focus();
                return;
            }
            if (soluong < 0)
            {
                MessageBox.Show("Số lượng không được nhỏ hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            //lớp x.lý
            try
            {
                string ten = tbTenSP.Text;
                string mota = tbMoTa.Text;

                if (xuLy.ThemSanPham(ten, gia, soluong, mota))
                {
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDuLieu();

                    tbTenSP.Text = "";
                    tbGia.Text = "";
                    tbSoLuong.Text = "";
                    tbMoTa.Text = "";
                    tbTenSP.Focus();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Không thể thêm sản phẩm giống nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message);
            }
        }

        private void btTaiLai_Click(object sender, EventArgs e)
        {
            TaiDuLieu();
        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex]; // lấy hàng đang đc click 
                maSPHienTai = Convert.ToInt32(row.Cells["MaSP"].Value); // lấy MaSP từ hàng và lưu vào biến maSPHienTai
                tbTenSP.Text = row.Cells["TenSP"].Value.ToString();
                tbGia.Text = row.Cells["DonGia"].Value.ToString();
                tbSoLuong.Text = row.Cells["SoLuongTon"].Value.ToString();
                tbMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (maSPHienTai == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để sửa!");
                return;
            }

            try
            {
                string ten = tbTenSP.Text;
                decimal gia = decimal.Parse(tbGia.Text);
                int soluong = int.Parse(tbSoLuong.Text);
                string mota = tbMoTa.Text;
                if (xuLy.SuaSanPham(maSPHienTai, ten, gia, soluong, mota))
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

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (maSPHienTai == 0)
            {
                MessageBox.Show("Bạn chưa chọn sản phẩm nào để xóa!");
                return;
            }
            DialogResult confirm = MessageBox.Show(
                "Bạn có chắc muốn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                if (xuLy.XoaSanPham(maSPHienTai))
                {
                    MessageBox.Show("Xóa thành công!");
                    TaiDuLieu();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void tbGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMoTa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
