using WinFormsApp1.GUI;

namespace WinFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GUI.Form1()); // Form đăng nhập
        }
    }
}
