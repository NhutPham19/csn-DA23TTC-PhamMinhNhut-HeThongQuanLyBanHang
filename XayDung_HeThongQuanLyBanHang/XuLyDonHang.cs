using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDung_HeThongQuanLyBanHang
{
    public class XuLyDonHang
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        public int TaoDonHang(int maKH, string nguoiBan, decimal tongTien, string phuongThucTT, string ghiChu)
        {
            string sql = "INSERT INTO DONHANG (MaKH, NguoiBan, TongTien, TrangThai, PhuongThucThanhToan, GhiChu) " +
                         "VALUES (" + maKH + ", '"+ nguoiBan +"', " + tongTien + ", N'Hoàn thành', N'" + phuongThucTT + "', N'" + ghiChu + "'); " +
                         "SELECT SCOPE_IDENTITY();";

            try
            {
                object id = ketnoi.ThaoTacTraVeGiaTri(sql);
                return Convert.ToInt32(id);
            }
            catch
            {
                return 0;
            }
        }

        public bool ThemChiTietDonHang(int maDonHang, int maSP, int soLuong, decimal donGia)
        {
            string sql_them_chitiet =
                "INSERT INTO CHITIETHOADON (MaDonHang, MaSP, SoLuong, DonGiaTaiThoiDiemMua) " +
                "VALUES (" + maDonHang + ", " + maSP + ", " + soLuong + ", " + donGia + ")";

            // câu lệnh UPDATE để trừ số lượng tồn kho
            string sql_tru_kho =
                "UPDATE SANPHAM " +
                "SET SoLuongTon = SoLuongTon - " + soLuong + " " +
                "WHERE MaSP = " + maSP;
            ketnoi.ThaoTacDuLieu(sql_tru_kho); // Trừ kho
            return ketnoi.ThaoTacDuLieu(sql_them_chitiet) > 0;
        }

        public DataTable LayDanhSachDonHang()
        {
            string sql = "SELECT dh.MaDonHang, dh.NgayTao, kh.HoTen, kh.SoDienThoai, dh.TongTien, dh.PhuongThucThanhToan, dh.GhiChu, dh.NguoiBan " +
                         "FROM DONHANG dh " +
                         "JOIN KHACHHANG kh ON dh.MaKH = kh.MaKH " +
                         "ORDER BY dh.NgayTao DESC";

            return ketnoi.DocDuLieu(sql);
        }

        public DataTable LayChiTietDonHang(int maDonHang)
        {
            string sql = "SELECT ct.MaSP, sp.TenSP, ct.SoLuong, ct.DonGiaTaiThoiDiemMua " +
                         "FROM CHITIETHOADON ct " +
                         "JOIN SANPHAM sp ON ct.MaSP = sp.MaSP " +
                         "WHERE ct.MaDonHang = " + maDonHang;

            return ketnoi.DocDuLieu(sql);
        }

        public DataTable TimKiemDonHang(string tuKhoa)
        {
            string sql = "SELECT dh.MaDonHang, dh.NguoiBan, dh.NgayTao, kh.HoTen, kh.SoDienThoai, dh.TongTien, dh.PhuongThucThanhToan, dh.GhiChu" +
                         "FROM DONHANG dh " +
                         "JOIN KHACHHANG kh ON dh.MaKH = kh.MaKH ";
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                sql += " WHERE (kh.HoTen LIKE N'%" + tuKhoa + "%' OR kh.SoDienThoai LIKE '%" + tuKhoa + "%') ";
            }

            sql += " ORDER BY dh.NgayTao DESC"; // sắp xếp 
            return ketnoi.DocDuLieu(sql);
        }
    }
}
