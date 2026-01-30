using System;
using System.Windows.Forms;
using Quanly.GUI; // Đảm bảo gọi đúng namespace chứa các Form

namespace Quanly
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // CHỈ CHẠY MỘT DÒNG NÀY: Mở Form Login trước
            // Sau khi đăng nhập thành công, code trong frmLogin sẽ tự mở Form1
            Application.Run(new frmLogin());
        }
    }
}