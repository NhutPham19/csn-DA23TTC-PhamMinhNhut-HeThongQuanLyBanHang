using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XayDung_HeThongQuanLyBanHang
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmQuanLiKhachHang());

            //Application.Run(new frmQuanLiSanPham());

            //Application.Run(new frmBanHang());

            //Application.Run(new frmLichSuDonHang());

            //Application.Run(new frmDoiMatKhau());

            Application.Run(new frmMain());
        }
    }
}
