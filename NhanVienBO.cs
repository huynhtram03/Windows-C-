namespace WinFormsApp1
{
    public class NhanVienBO
    {
        public string MaNV { get; set; } = string.Empty;
        public string HoTen { get; set; } = string.Empty;

        // Thông tin chấm công
        public string Ngay { get; set; } = string.Empty;
        public string GioVao { get; set; } = string.Empty;
        public string GioRa { get; set; } = string.Empty;

        // ID phòng ban (nếu cần liên kết)
        public int MaPB { get; set; }
    }
}
