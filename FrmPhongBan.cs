using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmPhongBan : Form
    {
        private Form? dashboard; // form dashboard cha

        private BindingList<PhongBanBO> dsPhongBan = new BindingList<PhongBanBO>();
        private int autoMa = 1;

        public FrmPhongBan(Form parent)
        {
            InitializeComponent();
            dashboard = parent;
        }

        private void FrmPhongBan_Load(object sender, EventArgs e)
        {
            // Setup DataGridView
            dgvPB.AutoGenerateColumns = true;
            dgvPB.DataSource = dsPhongBan;
            dgvPB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPB.ReadOnly = true;

            TaoDuLieuMau();
        }

        private void TaoDuLieuMau()
        {
            dsPhongBan.Add(new PhongBanBO { MaPB = autoMa++, TenPB = "Hành chính" });
            dsPhongBan.Add(new PhongBanBO { MaPB = autoMa++, TenPB = "Kế toán" });
            dsPhongBan.Add(new PhongBanBO { MaPB = autoMa++, TenPB = "Nhân sự" });
            dsPhongBan.Add(new PhongBanBO { MaPB = autoMa++, TenPB = "Kho" });
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenPB.Text))
            {
                MessageBox.Show("Vui lòng nhập tên phòng ban", "Thông báo");
                return;
            }

            dsPhongBan.Add(new PhongBanBO
            {
                MaPB = autoMa++,
                TenPB = txtTenPB.Text.Trim()
            });

            ClearInput();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvPB.CurrentRow == null) return;
            if (dgvPB.CurrentRow.DataBoundItem is not PhongBanBO pb) return;

            FrmSuaPhongBan frm = new FrmSuaPhongBan(pb);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dgvPB.Refresh();
                MessageBox.Show("Cập nhật thành công");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvPB.CurrentRow == null) return;
            if (dgvPB.CurrentRow.DataBoundItem is not PhongBanBO pb) return;

            if (MessageBox.Show("Xóa phòng ban này?", "Xác nhận",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dsPhongBan.Remove(pb);
            }
        }

        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvPB.Rows[e.RowIndex].DataBoundItem is not PhongBanBO pb) return;

            txtTenPB.Text = pb.TenPB;
        }

        private void ClearInput()
        {
            txtTenPB.Clear();
            txtTenPB.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            dashboard?.Show();
            this.Close();
        }
    }

    // ================= CLASS PHONG BAN =================
    public class PhongBanBO
    {
        public int MaPB { get; set; }
        public string TenPB { get; set; } = string.Empty;
    }
}
