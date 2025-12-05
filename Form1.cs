using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Article07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Chỉ cho nhập số và phím Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void tbYear_Validating(object sender, CancelEventArgs e)
        {
            // Nếu để trống → không kiểm tra
            if (string.IsNullOrWhiteSpace(tbYear.Text))
                return;

            // Kiểm tra năm
            if (!int.TryParse(tbYear.Text, out int year))
            {
                MessageBox.Show("Giá trị không hợp lệ!");
                e.Cancel = true;
                return;
            }

            if (year > 2000)
            {
                MessageBox.Show("Year must be ≤ 2000!");
                e.Cancel = true;
            }
        }
    }
}
