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
    public partial class frmLichSuDonHang : Form
    {
        XuLyDonHang bll_DonHang = new XuLyDonHang();
        public frmLichSuDonHang()
        {
            InitializeComponent();
        }

        private void fmLichSuDonHang_Load(object sender, EventArgs e)
        {
            dgvChiTietDonHang.RowTemplate.Height = 40;
            dgvDonHang.RowTemplate.Height = 40;
            dgvDonHang.DataSource = bll_DonHang.LayDanhSachDonHang();
            dgvChiTietDonHang.DataSource = null;
        }

        private void TaiDanhSachGoc()
        {
            dgvDonHang.DataSource = bll_DonHang.LayDanhSachDonHang();
            dgvChiTietDonHang.DataSource = null;
            tbTimKiem.Text = "";
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvDonHang.Rows[e.RowIndex];
                int maDonHangChon = Convert.ToInt32(row.Cells["MaDonHang"].Value); // lấy mã đ.hàng
                dgvChiTietDonHang.DataSource = bll_DonHang.LayChiTietDonHang(maDonHangChon);

                if (row.Cells["GhiChu"].Value != null)
                {
                    txtGhiChuLichSu.Text = row.Cells["GhiChu"].Value.ToString();
                }
                else
                {
                    txtGhiChuLichSu.Text = "";
                }
            }
            
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = tbTimKiem.Text;
            dgvDonHang.DataSource = bll_DonHang.TimKiemDonHang(tuKhoa);
            dgvChiTietDonHang.DataSource = null;
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiDanhSachGoc();
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
