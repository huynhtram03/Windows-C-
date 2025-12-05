using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Article16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cbFaculty.Items.Add("Công nghệ thông tin");
            cbFaculty.Items.Add("Quản trị kinh doanh");
            cbFaculty.Items.Add("Kế toán");
            cbFaculty.SelectedIndex = 0;

            rdMale.Checked = true;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            string gender = rdMale.Checked ? "Nam" : "Nữ";
            string info =
                $"{lbStatus.Items.Count + 1}. {tbName.Text}" +
                $"\n- Giới tính: {gender}" +
                $"\n- Ngày Sinh: {dtpBirth.Value.ToShortDateString()}" +
                $"\n- Khoa: {cbFaculty.SelectedItem}";

            lbStatus.Items.Add(info);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
