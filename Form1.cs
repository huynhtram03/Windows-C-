using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Article21
{
    public partial class Form1 : Form
    {
        private List<Employee> lst = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lst = GetData();
            LoadGrid();
        }

        private List<Employee> GetData()
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
            dgvEmployee.Rows.Clear();
            foreach (var em in lst)
            {
                dgvEmployee.Rows.Add(em.Id, em.Name, em.Age, em.Gender);
            }
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBId.Text) ||
                string.IsNullOrWhiteSpace(tBName.Text))
            {
                MessageBox.Show("Không được bỏ trống Mã hoặc Tên");
                return;
            }

            if (!int.TryParse(tBAge.Text, out int age))
            {
                MessageBox.Show("Tuổi phải là số");
                return;
            }

            var em = new Employee
            {
                Id = tBId.Text,
                Name = tBName.Text,
                Age = age,
                Gender = ckGender.Checked
            };

            lst.Add(em);
            LoadGrid();
            ClearText();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn dòng để xóa");
                return;
            }

            int index = dgvEmployee.CurrentRow.Index;

            if (index >= 0 && index < lst.Count)
            {
                lst.RemoveAt(index);
                LoadGrid();
                ClearText();
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            if (i < 0 || i >= lst.Count)
                return;

            tBId.Text = lst[i].Id;
            tBName.Text = lst[i].Name;
            tBAge.Text = lst[i].Age.ToString();
            ckGender.Checked = lst[i].Gender;
        }

        private void ClearText()
        {
            tBId.Clear();
            tBName.Clear();
            tBAge.Clear();
            ckGender.Checked = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
