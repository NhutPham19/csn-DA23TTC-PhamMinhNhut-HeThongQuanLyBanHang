using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDung_HeThongQuanLyBanHang
{
    public class XuLySanPham
    {
        KetNoiDuLieu ketnoi = new KetNoiDuLieu(); //tạo đ.tượng ketnoi
        public DataTable LayDanhSachSanPham()
        {
            string sql = "SELECT * FROM SANPHAM WHERE DaXoa = 0"; //lấy những sp chưa bị xóa (DaXoa = 0)
            return ketnoi.DocDuLieu(sql);
        }
        public bool ThemSanPham(string tenSP, decimal donGia, int soLuongTon, string moTa)
        {
            string sqlKiemTra = "SELECT * FROM SANPHAM WHERE TenSP = N'" + tenSP + "'";
            System.Data.DataTable dt = ketnoi.DocDuLieu(sqlKiemTra);

            if (dt.Rows.Count > 0)
            {
                return false;
            }
            string sql = "INSERT INTO SANPHAM (TenSP, DonGia, SoLuongTon) " +
                         "VALUES (N'" + tenSP + "', " + donGia + ", " + soLuongTon + ")";

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }

        public bool XoaSanPham(int maSP)
        {
            string sql = "UPDATE SANPHAM SET DaXoa = 1 WHERE MaSP = " + maSP;
            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }

        public bool SuaSanPham(int maSP, string tenSP, decimal donGia, int soLuongTon, string moTa)
        {
            // cập nhật dữ liệu vào bảng SANPHAM
            string sql = "UPDATE SANPHAM " +
                         "SET TenSP = N'" + tenSP + "', " +
                         "    DonGia = " + donGia + ", " +
                         "    SoLuongTon = " + soLuongTon + ", " +
                         "    MoTa = N'" + moTa + "' " +
                         "WHERE MaSP = " + maSP;

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }
    }
}
