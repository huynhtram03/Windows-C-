using System;
using System.Collections.Generic;
using System.Data; // Thêm thư viện này để dùng DataTable
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanly.DAL
{
    public class UserDAL
    {
        // Chuỗi kết nối đến database 'sale'
        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=sale;Integrated Security=True";

        public bool CheckLogin(string user, string pass)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    con.Open();
                    string sql = "SELECT COUNT(*) FROM Users WHERE Username=@user AND Password=@pass";
                    using (SqlCommand cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false; // Trả về false nếu kết nối database thất bại
            }
        }

        // BỔ SUNG: Hàm lấy dữ liệu sinh viên cho Dashboard
        public DataTable GetAllStudents()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection con = new SqlConnection(strCon))
                {
                    string sql = "SELECT * FROM Students"; // Đảm bảo bạn đã tạo bảng Students trong SQL
                    SqlDataAdapter da = new SqlDataAdapter(sql, con);
                    da.Fill(dt);
                }
            }
            catch (Exception) { /* Xử lý lỗi kết nối tại đây */ }
            return dt;
        }
    }
}