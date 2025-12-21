using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmSuaPhongBan : Form
    {
        private PhongBanBO phongBan;

        public FrmSuaPhongBan(PhongBanBO pb)
        {
            InitializeComponent();
            phongBan = pb;

            // Gán dữ liệu lên form
            txtTenPB.Text = phongBan.TenPB;
        }

        // ================= NÚT LƯU =================
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPB.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban", "Thông báo");
                return;
            }

            // Cập nhật dữ liệu
            phongBan.TenPB = txtTenPB.Text.Trim();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // ================= NÚT THOÁT =================
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    // ================= CLASS PHONGBAN BO =================
}
