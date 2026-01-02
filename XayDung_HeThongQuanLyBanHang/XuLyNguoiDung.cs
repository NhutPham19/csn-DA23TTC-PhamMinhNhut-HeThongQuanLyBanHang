using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDung_HeThongQuanLyBanHang
{
    public class XuLyNguoiDung
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        public DataTable KiemTraDangNhap(string tenDangNhap, string matKhau)
        {
            // Tìm trong bảng NGUOIDUNG xem có ai khớp tên và mật khẩu không
            string sql = "SELECT * FROM NGUOIDUNG " +
                         "WHERE TenDangNhap = N'" + tenDangNhap + "' " +
                         "AND MatKhau = N'" + matKhau + "'";
            return ketnoi.DocDuLieu(sql);
        }
    }
}
