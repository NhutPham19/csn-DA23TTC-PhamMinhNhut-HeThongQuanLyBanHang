using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDung_HeThongQuanLyBanHang
{
    public class ChiTietHoaDon
    {
        // Khóa ngoại liên kết đến DONHANG
        public int MaDonHang { get; set; }

        // Khóa ngoại liên kết đến SANPHAM
        public int MaSP { get; set; }

        public int SoLuong { get; set; }
        public decimal DonGiaTaiThoiDiemMua { get; set; }
    }
}
