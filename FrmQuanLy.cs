using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmQuanLy : Form
    {
        private Form? dashboard;       // cho phép null

        private BindingList<UserBO> dsNhanVien = new BindingList<UserBO>();
        private int autoMa = 1;

        // Nhận form dashboard khi mở
        public FrmQuanLy(Form parent)
        {
            InitializeComponent();
            dashboard = parent;
        }

        private void FrmQuanLy_Load(object sender, EventArgs e)
        {
            cboChucVu.Items.AddRange(new string[]
            {
                "Quản lý",
                "Nhân viên",
                "Kế toán",
                "Thủ kho"
            });
            cboChucVu.SelectedIndex = 0;

            dgvNV.AutoGenerateColumns = true;
            dgvNV.DataSource = dsNhanVien;
            dgvNV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNV.ReadOnly = true;

            TaoDuLieuMau();
        }

        private void TaoDuLieuMau()
        {
            dsNhanVien.Add(new UserBO { MaNV = autoMa++, TenNV = "Nguyễn Văn A", TaiKhoan = "admin", MatKhau = "123", ChucVu = "Quản lý" });
            dsNhanVien.Add(new UserBO { MaNV = autoMa++, TenNV = "Trần Thị B", TaiKhoan = "ketoan01", MatKhau = "123", ChucVu = "Kế toán" });
            dsNhanVien.Add(new UserBO { MaNV = autoMa++, TenNV = "Lê Văn C", TaiKhoan = "nv01", MatKhau = "123", ChucVu = "Nhân viên" });
            dsNhanVien.Add(new UserBO { MaNV = autoMa++, TenNV = "Phạm Thị D", TaiKhoan = "kho01", MatKhau = "123", ChucVu = "Thủ kho" });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) ||
                string.IsNullOrWhiteSpace(txtTaiKhoan.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo");
                return;
            }

            dsNhanVien.Add(new UserBO
            {
                MaNV = autoMa++,
                TenNV = txtTenNV.Text.Trim(),
                TaiKhoan = txtTaiKhoan.Text.Trim(),
                MatKhau = txtMatKhau.Text,
                ChucVu = cboChucVu.Text
            });

            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNV.CurrentRow == null) return;
            if (dgvNV.CurrentRow.DataBoundItem is not UserBO nv) return;

            FrmSuaNhanVien frm = new FrmSuaNhanVien(nv);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvNV.Refresh();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNV.CurrentRow == null) return;
            if (dgvNV.CurrentRow.DataBoundItem is not UserBO nv) return;

            if (MessageBox.Show("Xóa nhân viên này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsNhanVien.Remove(nv);
            }
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvNV.Rows[e.RowIndex].DataBoundItem is not UserBO nv) return;

            txtTenNV.Text = nv.TenNV;
            txtTaiKhoan.Text = nv.TaiKhoan;
            txtMatKhau.Text = nv.MatKhau;
            cboChucVu.Text = nv.ChucVu;
        }

        private void ClearInput()
        {
            txtTenNV.Clear();
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
            cboChucVu.SelectedIndex = 0;
            txtTenNV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dashboard?.Show();   // đảm bảo không crash
            this.Close();
        }
    }
}
