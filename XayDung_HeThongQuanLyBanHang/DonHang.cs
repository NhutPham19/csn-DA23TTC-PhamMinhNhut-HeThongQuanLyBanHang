using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XayDung_HeThongQuanLyBanHang
{
    public class DonHang
    {
        public int MaDonHang { get; set; } 
        public DateTime NgayTao { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; }

        // Khóa ngoại liên kết đến KHACHHANG
        public int MaKH { get; set; }
    }
}
