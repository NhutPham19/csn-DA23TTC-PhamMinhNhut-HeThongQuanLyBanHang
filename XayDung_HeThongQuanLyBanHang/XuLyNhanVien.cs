using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDung_HeThongQuanLyBanHang
{
    public class XuLyNhanVien
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        public DataTable LayDanhSachNhanVien()
        {
            string sql = "SELECT TenDangNhap, HoTen, SoDienThoai, Quyen FROM NGUOIDUNG";
            return ketnoi.DocDuLieu(sql);
        }
        public bool ThemNhanVien(string tenDN, string hoTen, string sodienthoai, string quyen)
        {
            // ktra trùng tên hay k
            string sqlKiemTra = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '" + tenDN + "'";
            if (ketnoi.DocDuLieu(sqlKiemTra).Rows.Count > 0) 
                return false; // đã tồn tại

            string sql = "INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, HoTen, SoDienThoai, Quyen) " +
                         "VALUES ('" + tenDN + "', '123', N'" + hoTen + "', '"+sodienthoai+"', '" + quyen + "')";

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
        public bool SuaNhanVien(string tenDN, string hoTen, string soDienThoai, string quyen)
        {
            if (tenDN.ToLower() == "admin" && quyen != "Admin")
            {
                // nếu đang sửa admin mà quyền mới ko phải admin thì CHẶN 
                MessageBox.Show("Không thể sửa quyền 'Admin' thành 'Nhân viên'", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;

            }
            string sql = "UPDATE NGUOIDUNG " +
                         "SET HoTen = N'" + hoTen + "', SoDienThoai = '"+soDienThoai+"', Quyen = '" + quyen + "' " +
                         "WHERE TenDangNhap = '" + tenDN + "'";

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
        public bool XoaNhanVien(string tenDN)
        {
            // ko cho xóa tài khoản admin gốc
            if (tenDN.ToLower() == "admin") return false;

            string sql = "DELETE FROM NGUOIDUNG WHERE TenDangNhap = '" + tenDN + "'";
            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
        public bool ResetMatKhau(string tenDN)
        {
            string sql = "UPDATE NGUOIDUNG SET MatKhau = '123' WHERE TenDangNhap = '" + tenDN + "'";
            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }

        // ktra m.khau cũ
        public bool KiemTraMatKhauCu(string tenDN, string matKhauCu)
        {
            string sql = "SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '" + tenDN + "' AND MatKhau = '" + matKhauCu + "'";
            DataTable dt = ketnoi.DocDuLieu(sql);
            return dt.Rows.Count > 0;
        }

        // cập nhật mk mới
        public bool DoiMatKhau(string tenDN, string matKhauMoi)
        {
            string sql = "UPDATE NGUOIDUNG SET MatKhau = '" + matKhauMoi + "' WHERE TenDangNhap = '" + tenDN + "'";
            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
    }
}
