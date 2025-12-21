using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmChamCong : Form
    {
        private FrmDashboard _dashboard;
        private DataTable dtChamCong; // DataTable toàn cục để thao tác

        public FrmChamCong(FrmDashboard dashboard)
        {
            _dashboard = dashboard;
            InitializeComponent();
            InitializeDataGrid();
        }

        public FrmChamCong()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        // ================== KHỞI TẠO DATA ==================
        private void InitializeDataGrid()
        {
            dtChamCong = new DataTable();
            dtChamCong.Columns.Add("Mã NV");
            dtChamCong.Columns.Add("Họ Tên");
            dtChamCong.Columns.Add("Ngày");
            dtChamCong.Columns.Add("Giờ Vào");
            dtChamCong.Columns.Add("Giờ Ra");

            // Thêm dữ liệu mẫu
            dtChamCong.Rows.Add("NV01", "Nguyễn Văn A", "2025-12-19", "08:00", "17:00");
            dtChamCong.Rows.Add("NV02", "Trần Thị B", "2025-12-19", "08:15", "17:05");
            dtChamCong.Rows.Add("NV03", "Lê Văn C", "2025-12-19", "07:55", "16:50");
            dtChamCong.Rows.Add("NV04", "Phạm Thị D", "2025-12-19", "08:10", "17:10");

            dgvChamCong.DataSource = dtChamCong;
            dgvChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChamCong.MultiSelect = false;
            dgvChamCong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ================== THÊM ==================
        private void BtnThem_Click(object sender, EventArgs e)
        {
            FrmThemChamCong f = new FrmThemChamCong(); // Form phụ nhập liệu đầy đủ
            if (f.ShowDialog() == DialogResult.OK)
            {
                dtChamCong.Rows.Add(f.MaNV, f.HoTen, f.Ngay, f.GioVao, f.GioRa);
            }
        }

        // ================== SỬA ==================
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!");
                return;
            }

            DataGridViewRow row = dgvChamCong.SelectedRows[0];

            string maNV = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập Mã NV:", "Sửa chấm công", row.Cells["Mã NV"].Value.ToString());
            string hoTen = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập Họ Tên:", "Sửa chấm công", row.Cells["Họ Tên"].Value.ToString());
            string ngay = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập Ngày (yyyy-MM-dd):", "Sửa chấm công", row.Cells["Ngày"].Value.ToString());
            string gioVao = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập Giờ Vào (HH:mm):", "Sửa chấm công", row.Cells["Giờ Vào"].Value.ToString());
            string gioRa = Microsoft.VisualBasic.Interaction.InputBox(
                "Nhập Giờ Ra (HH:mm):", "Sửa chấm công", row.Cells["Giờ Ra"].Value.ToString());

            row.Cells["Mã NV"].Value = maNV;
            row.Cells["Họ Tên"].Value = hoTen;
            row.Cells["Ngày"].Value = ngay;
            row.Cells["Giờ Vào"].Value = gioVao;
            row.Cells["Giờ Ra"].Value = gioRa;
        }

        // ================== XÓA ==================
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvChamCong.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!");
                return;
            }

            if (MessageBox.Show(
                "Bạn có chắc muốn xóa chấm công này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dgvChamCong.Rows.RemoveAt(dgvChamCong.SelectedRows[0].Index);
            }
        }

        // ================== THOÁT ==================
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            if (_dashboard != null)
                _dashboard.Show();
            this.Close();
        }
    }
}
