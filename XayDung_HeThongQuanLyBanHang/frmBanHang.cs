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
    public partial class frmBanHang : Form
    {
        XuLySanPham bll_SanPham = new XuLySanPham();
        XuLyKhachHang bll_KhachHang = new XuLyKhachHang();
        XuLyDonHang bll_DonHang = new XuLyDonHang();
        DataTable gioHang = new DataTable();
        private int maSPGioHangChon = 0; // biến lưu mã SP đang được chọn dùng cho xóa sửa.
        public frmBanHang()
        {
            InitializeComponent();
        }
        private void TaiDanhSachSanPham()
        {
            dgvDanhSachSP.DataSource = bll_SanPham.LayDanhSachSanPham();

            if (dgvDanhSachSP.Columns["DaXoa"] != null)
            {
                dgvDanhSachSP.Columns["DaXoa"].Visible = false;
            }
        }


        private void LoadComboBoxKhachHang()
        {
            cbKhachHang.DataSource = bll_KhachHang.LayDanhSachKhachHang();
            cbKhachHang.DisplayMember = "HoTen";
            cbKhachHang.ValueMember = "MaKH";
            cbKhachHang.SelectedIndex = cbKhachHang.FindStringExact("Khách vãng lai");
        }

        
        private void TaoCauTrucGioHang()
        {
            gioHang.Columns.Add("MaSP", typeof(int));
            gioHang.Columns.Add("TenSP", typeof(string));
            gioHang.Columns.Add("DonGia", typeof(decimal));
            gioHang.Columns.Add("SoLuong", typeof(int));
            gioHang.Columns.Add("ThanhTien", typeof(decimal), "DonGia * SoLuong");
            dgvGioHang.DataSource = gioHang;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            TaiDanhSachSanPham();
            LoadComboBoxKhachHang();
            TaoCauTrucGioHang();

            //kich thuoc dong
            dgvDanhSachSP.RowTemplate.Height = 40;
            dgvGioHang.RowTemplate.Height = 40;
        }
        private void frmBanHang_Activated(object sender, EventArgs e)
        {
            TaiDanhSachSanPham();
            LoadComboBoxKhachHang();
        }

        private void btThemVaoGio_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSP.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm!");
                return;
            }

            DataGridViewRow rowSP = dgvDanhSachSP.CurrentRow;
            int maSP = Convert.ToInt32(rowSP.Cells["MaSP_DS"].Value);
            string tenSP = rowSP.Cells["TenSP_DS"].Value.ToString();
            decimal donGia = Convert.ToDecimal(rowSP.Cells["DonGia_DS"].Value);
            int soLuongThem = (int)numSoLuong.Value;

            // ktra tồn kho
            int soLuongTon = Convert.ToInt32(rowSP.Cells["SoLuongTon_DS"].Value);
            if (soLuongTon <= 0)
            {
                MessageBox.Show("Sản phẩm [" + tenSP + "] đã hết hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // lấy s.luong hien tai trong gio 
            int soLuongHienTaiTrongGio = 0;
            DataRow rowGioHang = gioHang.AsEnumerable().FirstOrDefault(r => r.Field<int>("MaSP") == maSP);
            if (rowGioHang != null)
            {
                soLuongHienTaiTrongGio = rowGioHang.Field<int>("SoLuong");
            }

            // kta tổng s.luong muốn mua (s.luong hien tai + s.luong them )
            int tongSoLuongMuonMua = soLuongHienTaiTrongGio + soLuongThem;
            if (tongSoLuongMuonMua > soLuongTon)
            {
                MessageBox.Show("Số lượng tồn kho không đủ!\n" +
                                "\n- Sản phẩm: " + tenSP +
                                "\n- Tồn kho: " + soLuongTon +
                                "\n- Đã có trong giỏ: " + soLuongHienTaiTrongGio,
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            if (rowGioHang != null)
            {
                rowGioHang["SoLuong"] = tongSoLuongMuonMua; // sp đã có thì c.nhật lại s.luong
            }
            else
            {
                gioHang.Rows.Add(maSP, tenSP, donGia, soLuongThem); // sp chưa có thì thêm mới sp vào giỏ 
            }
            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tongTien = 0;
            if (gioHang.Rows.Count > 0)
            {
                tongTien = (decimal)gioHang.Compute("SUM(ThanhTien)", string.Empty);
            }

            // h.thi lên textbox định dạng N0 là có dấu phẩy
            tbTongTien.Text = tongTien.ToString("N0"); // 1,000,000
        }

        private void dgvGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGioHang.Rows[e.RowIndex];
                maSPGioHangChon = Convert.ToInt32(row.Cells["MaSP_gioHang"].Value);
                numSuaSoLuong.Value = Convert.ToDecimal(row.Cells["SoLuong_gioHang"].Value); // đẩy số lượng của hàng này lên ô "numSuaSoLuong"
            }
        }

        private void numSuaSoLuong_ValueChanged(object sender, EventArgs e)
        {
            if (maSPGioHangChon == 0) return; // chưa chọn SP nào
            DataRow rowGioHang = gioHang.AsEnumerable().FirstOrDefault(r => r.Field<int>("MaSP") == maSPGioHangChon);

            if (rowGioHang != null)
            {
                rowGioHang["SoLuong"] = (int)numSuaSoLuong.Value; // cập nhật số lượng mới từ numSuaSoLuong
                CapNhatTongTien();
            }
        }

        private void btXoaKhoiGio_Click(object sender, EventArgs e)
        {
            if (maSPGioHangChon == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong giỏ hàng để xóa!");
                return;
            }
            DataRow rowGioHang = gioHang.AsEnumerable().FirstOrDefault(r => r.Field<int>("MaSP") == maSPGioHangChon);

            if (rowGioHang != null)
            {
                gioHang.Rows.Remove(rowGioHang);
                maSPGioHangChon = 0;
                numSuaSoLuong.Value = 1;
                CapNhatTongTien();
            }
        }

        private void btHuyDon_Click(object sender, EventArgs e)
        {
            txtGhiChu.Text = "";
            gioHang.Clear();
            maSPGioHangChon = 0;
            numSuaSoLuong.Value = 1;
            CapNhatTongTien();
            cbKhachHang.SelectedIndex = cbKhachHang.FindStringExact("Khách vãng lai"); // Chọn lại khách vãng lai
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!");
                return;
            }

            int maKH = (int)cbKhachHang.SelectedValue; // lấy MaKH từ cbBox
            string nguoiBan = ThongTinNguoiDung.TenDangNhapHienTai;
            decimal tongTien = decimal.Parse(tbTongTien.Text.Replace(",", "")); // lấy tổng tièn 
            string phuongThucTT = rbTienMat.Checked ? "Tiền mặt" : "Chuyển khoản";
            string ghiChu = txtGhiChu.Text;
            int maDonHangMoi = bll_DonHang.TaoDonHang(maKH, nguoiBan, tongTien, phuongThucTT, ghiChu);

            if (maDonHangMoi > 0)
            {
                try
                {
                    foreach (DataRow row in gioHang.Rows)
                    {
                        int maSP = (int)row["MaSP"];
                        int soLuong = (int)row["SoLuong"];
                        decimal donGia = (decimal)row["DonGia"];
                        bll_DonHang.ThemChiTietDonHang(maDonHangMoi, maSP, soLuong, donGia); //hàm tự động trừ kho 
                    }

                    MessageBox.Show("Thanh toán thành công! Đã tạo đơn hàng #" + maDonHangMoi);


                    dgvDanhSachSP.DataSource = bll_SanPham.LayDanhSachSanPham(); // cập nhật s.luong tồn kho 
                    btHuyDon_Click(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu chi tiết đơn hàng: " + ex.Message);
                }
            }
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhachHang.SelectedItem != null)
            {
                try
                {
                    DataRowView drv = (DataRowView)cbKhachHang.SelectedItem;
                    tbSDT_KH.Text = drv["SoDienThoai"].ToString();
                }
                catch
                {
                    tbSDT_KH.Text = "";
                }
            }
        }
        private void rbTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTienMat.Checked)
            {
                anhQR.Visible = false; // ẩn qr
                pnlTienMat.Visible = true; // hiện khung nhập tiền mặt
                txtTienKhachDua.Focus();
            }
        }
        private void rbChuyenKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbChuyenKhoan.Checked)
            {
                anhQR.Image = Properties.Resources.QR_2;
                anhQR.Visible = true;
                pnlTienMat.Visible = false; // ẩn khung nhập tiền mặt 
            }
        }
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal tongTien = 0; //lấy tổng tiền
                if (!string.IsNullOrEmpty(tbTongTien.Text))
                {
                    tongTien = decimal.Parse(tbTongTien.Text.Replace(",", ""));
                }

                // TryParse để tránh lỗi nếu người dùng xóa hết chữ hoặc nhập sai
                decimal tienKhachDua = 0;
                if (decimal.TryParse(txtTienKhachDua.Text.Replace(",", ""), out tienKhachDua))
                {
                    decimal tienKhachDuaThucTe = tienKhachDua * 1000; // nhân 1000 để tiện hơn
                    decimal tienThua = tienKhachDuaThucTe - tongTien;   

                    // hiển thị ra ô tiền thừa 
                    txtTienThua.Text = tienThua.ToString("N0");
                }
                else
                {
                    txtTienThua.Text = "0";
                }
            }
            catch
            {
                // bo qua lỗi 
            }
        }







        // hết 
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numSoLuong_ValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}
