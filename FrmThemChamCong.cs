using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmThemChamCong : Form
    {
        public string MaNV { get; private set; }
        public string HoTen { get; private set; }
        public string Ngay { get; private set; }
        public string GioVao { get; private set; }
        public string GioRa { get; private set; }

        public FrmThemChamCong()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // Lấy dữ liệu từ TextBox
            MaNV = txtMaNV.Text.Trim();
            HoTen = txtHoTen.Text.Trim();
            Ngay = dtpNgay.Value.ToString("yyyy-MM-dd");
            GioVao = txtGioVao.Text.Trim();
            GioRa = txtGioRa.Text.Trim();

            if (string.IsNullOrWhiteSpace(MaNV) || string.IsNullOrWhiteSpace(HoTen))
            {
                MessageBox.Show("Mã NV và Họ Tên không được để trống!");
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
