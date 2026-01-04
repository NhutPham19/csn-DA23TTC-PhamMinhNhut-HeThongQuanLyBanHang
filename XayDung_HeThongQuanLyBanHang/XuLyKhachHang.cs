using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDung_HeThongQuanLyBanHang
{
    public class XuLyKhachHang
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu();
        public DataTable LayDanhSachKhachHang()
        {
            string sql = "SELECT MaKH, HoTen, SoDienThoai, DiaChi FROM KHACHHANG WHERE DaXoa = 0";
            return ketnoi.DocDuLieu(sql);
        }

        public bool ThemKhachHang(string tenKH, string sdt, string diaChi)
        {
            string sqlKiemTra = "SELECT * FROM KHACHHANG WHERE SoDienThoai = '" + sdt + "' AND DaXoa = 0";
            System.Data.DataTable dt = ketnoi.DocDuLieu(sqlKiemTra);

            if (dt.Rows.Count > 0)
            {
                return false;
            }

            string sql = "INSERT INTO KHACHHANG (HoTen, SoDienThoai, DiaChi) " +
                         "VALUES (N'" + tenKH + "', '" + sdt + "', N'" + diaChi + "')";

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
        public bool SuaKhachHang(int maKH, string tenKH, string sdt, string diaChi)
        {
            string sql = "UPDATE KHACHHANG " +
                         "SET HoTen = N'" + tenKH + "', " +
                         "    SoDienThoai = '" + sdt + "', " +
                         "    DiaChi = N'" + diaChi + "' " +
                         "WHERE MaKH = " + maKH;

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
        public bool XoaKhachHang(int maKH)
        {
            string sql = "UPDATE KHACHHANG SET DaXoa = 1 WHERE MaKH = " + maKH;
            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
    }
}
