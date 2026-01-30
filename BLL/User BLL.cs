using Quanly.DAL;
using System;
using System.Data; // Thêm thư viện này để dùng DataTable

namespace Quanly.BLL
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();

        public bool Login(string user, string pass)
        {
            // Kiểm tra rỗng hoặc chỉ có khoảng trắng
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
                return false;

            return dal.CheckLogin(user, pass);
        }

        // Thêm hàm này để gọi từ Form1 (Dashboard)
        public DataTable GetAllStudents()
        {
            // Giả sử bạn đã thêm hàm GetAllStudents trong UserDAL
            return dal.GetAllStudents();
        }
    }
}