using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmSuaNhanVien : Form
    {
        private UserBO nv;

        public FrmSuaNhanVien(UserBO nhanVien)
        {
            InitializeComponent();
            nv = nhanVien;
        }

        private void FrmSuaNhanVien_Load(object sender, EventArgs e)
        {
            cboChucVu.Items.AddRange(new string[]
            {
                "Quản lý",
                "Nhân viên",
                "Kế toán",
                "Thủ kho"
            });

            // Đổ dữ liệu lên form
            txtTenNV.Text = nv.TenNV;
            txtTaiKhoan.Text = nv.TaiKhoan;
            txtMatKhau.Text = nv.MatKhau;
            cboChucVu.Text = nv.ChucVu;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }

            // Cập nhật lại object gốc
            nv.TenNV = txtTenNV.Text.Trim();
            nv.TaiKhoan = txtTaiKhoan.Text.Trim();
            nv.MatKhau = txtMatKhau.Text;
            nv.ChucVu = cboChucVu.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
