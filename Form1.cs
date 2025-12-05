using System;
using System.Windows.Forms;

namespace Article20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Dùng Rows.Add phù hợp với kiểu cột
            dgvNhanVien.Rows.Add("53418", "Trần Tiến", 20, true);
            dgvNhanVien.Rows.Add("53416", "Nguyễn Cường", 25, false);
            dgvNhanVien.Rows.Add("53417", "Nguyễn Hào", 23, true);
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Chặn click header
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

            tbMa.Text = row.Cells["colMa"].Value?.ToString() ?? "";
            tbTen.Text = row.Cells["colTen"].Value?.ToString() ?? "";
            tbTuoi.Text = row.Cells["colTuoi"].Value?.ToString() ?? "";

            var v = row.Cells["colGioiTinh"].Value;
            if (v is bool b) chkNam.Checked = b;
            else chkNam.Checked = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbMa.Text) ||
                string.IsNullOrWhiteSpace(tbTen.Text) ||
                string.IsNullOrWhiteSpace(tbTuoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(tbTuoi.Text, out int tuoi))
            {
                MessageBox.Show("Tuổi phải là số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgvNhanVien.Rows.Add(tbMa.Text, tbTen.Text, tuoi, chkNam.Checked);
            MessageBox.Show("Đã thêm nhân viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.CurrentRow != null)
            {
                dgvNhanVien.Rows.Remove(dgvNhanVien.CurrentRow);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
