using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Article22
{
    public partial class Form1 : Form
    {
        // Dùng List như hiện tại. Bạn có thể đổi BindingList nếu muốn auto-sync.
        private List<Employee> lst = new List<Employee>();

        public Form1()
        {
            InitializeComponent();

            // bảo vệ: only set this if dgvEmployee đã khởi tạo trong InitializeComponent
            if (dgvEmployee != null)
            {
                dgvEmployee.AllowUserToAddRows = false;
                // đảm bảo selection mode hợp lý
                dgvEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lst = GetData();
                LoadGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load form: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Employee> GetData()
        {
            return new List<Employee>
            {
                new Employee { Id = "53418", Name = "Trần Tiến", Age = 20, Gender = true },
                new Employee { Id = "53416", Name = "Nguyễn Cường", Age = 25, Gender = false },
                new Employee { Id = "53417", Name = "Nguyễn Hảo", Age = 23, Gender = true }
            };
        }

        private void LoadGrid()
        {
            try
            {
                if (dgvEmployee == null) return;

                dgvEmployee.Rows.Clear();

                foreach (var em in lst)
                {
                    // đảm bảo đủ cột — nếu designer có số cột khác thì dùng safe-add (cột autogen)
                    // giả sử DataGridView đã có 4 cột: Id, Name, Age, Gender (theo thứ tự)
                    dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load grid: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee == null)
                {
                    MessageBox.Show("DataGridView chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string id = tBId?.Text?.Trim() ?? string.Empty;
                string name = tBName?.Text?.Trim() ?? string.Empty;
                string ageText = tBAge?.Text?.Trim() ?? string.Empty;
                bool gender = ckGender != null && ckGender.Checked;

                if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Mã và tên không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(ageText, out int age) || age <= 0)
                {
                    MessageBox.Show("Tuổi phải là số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tBAge?.Focus();
                    return;
                }

                if (lst.Any(x => x.Id.Equals(id, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var em = new Employee
                {
                    Id = id,
                    Name = name,
                    Age = age,
                    Gender = gender
                };

                lst.Add(em);
                LoadGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm nhân viên: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployee == null)
                {
                    MessageBox.Show("DataGridView chưa được khởi tạo.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ưu tiên dùng SelectedRows (an toàn hơn khi multi-select off thì là 1)
                if (dgvEmployee.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                int idx = dgvEmployee.SelectedRows[0].Index;

                if (idx < 0 || idx >= lst.Count)
                {
                    MessageBox.Show("Dòng chọn không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show($"Bạn có muốn xóa nhân viên '{lst[idx].Name}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm != DialogResult.Yes) return;

                lst.RemoveAt(idx);
                LoadGrid();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ignore header clicks
                if (e.RowIndex < 0) return;

                int idx = e.RowIndex;
                if (idx < 0 || idx >= lst.Count) return;

                var em = lst[idx];
                tBId.Text = em.Id;
                tBName.Text = em.Name;
                tBAge.Text = em.Age.ToString();
                if (ckGender != null) ckGender.Checked = em.Gender;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn dòng: {ex.Message}\n{ex.StackTrace}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            try
            {
                tBId?.Clear();
                tBName?.Clear();
                tBAge?.Clear();
                if (ckGender != null) ckGender.Checked = false;
                tBId?.Focus();
            }
            catch { /* ignore */ }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đóng form: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
