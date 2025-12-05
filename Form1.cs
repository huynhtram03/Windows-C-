using System;
using System.Windows.Forms;

namespace Article15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            // Khi nhấn OK → hiển thị dạng LongDate
            this.Text = dtpDate.Value.ToLongDateString();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // Khi thay đổi ngày → hiển thị dạng ShortDate
            this.Text = dtpDate.Value.ToShortDateString();
        }
    }
}
