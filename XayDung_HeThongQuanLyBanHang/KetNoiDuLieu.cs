using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//thu vien 
namespace XayDung_HeThongQuanLyBanHang
{
    public class KetNoiDuLieu
    {
        private string connectionString ="Data Source=DESKTOP-C214NVV\\MAYCHU;Initial Catalog=QuanLyBanHang;Integrated Security=True;";
        public DataTable DocDuLieu(string sqlQuery)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection ketnoi = new SqlConnection(connectionString))
            {
                try
                {
                    ketnoi.Open();
                    SqlDataAdapter bodocghi = new SqlDataAdapter(sqlQuery, ketnoi);
                    bodocghi.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message);
                    dataTable = null;
                }
            }
            return dataTable;
        }
        // dùng cho INSERT, UPDATE, DELETE
        public int ThaoTacDuLieu(string sqlQuery)
        {
            int soDongAnhHuong = 0;
            using (SqlConnection ketnoi = new SqlConnection(connectionString))
            {
                try
                {
                    ketnoi.Open();
                    SqlCommand lenh = new SqlCommand(sqlQuery, ketnoi);
                    soDongAnhHuong = lenh.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thao tác dữ liệu: " + ex.Message);
                    soDongAnhHuong = -1; // báo lỗi
                }
            }
            return soDongAnhHuong;
        }

        public object ThaoTacTraVeGiaTri(string sqlQuery)
        {
            object value = null; // biến lưu trữ id trả về
            using (SqlConnection ketnoi = new SqlConnection(connectionString))
            {
                try
                {
                    ketnoi.Open();
                    SqlCommand lenh = new SqlCommand(sqlQuery, ketnoi);
                    value = lenh.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thao tác (ExecuteScalar): " + ex.Message);
                }
            }
            return value;
        }
    }
}
