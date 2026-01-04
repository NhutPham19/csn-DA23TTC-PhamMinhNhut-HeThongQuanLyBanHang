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
            string sqlKiemTra = "SELECT MaSP FROM SANPHAM WHERE TenSP = N'" + tenSP + "' AND DaXoa = 0";
            System.Data.DataTable dt = ketnoi.DocDuLieu(sqlKiemTra);

            if (dt.Rows.Count > 0)
            {
                return false;
            }

            string sql = "INSERT INTO SANPHAM (TenSP, DonGia, SoLuongTon, MoTa) " +
                         "VALUES (N'" + tenSP + "', " + donGia + ", " + soLuongTon + ", N'" + moTa + "')";

            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }

        public bool XoaSanPham(int maSP)
        {
            // dùng xóa mềm
            string sql = "UPDATE SANPHAM SET DaXoa = 1 WHERE MaSP = " + maSP;
            return ketnoi.ThaoTacDuLieu(sql) > 0;
        }

        public bool SuaSanPham(int maSP, string tenSP, decimal donGia, int soLuongTon, string moTa)
        {
            //cập nhật
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
