using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void btnQuanLyNV_Click(object sender, EventArgs e)
        {
            FrmQuanLy f = new FrmQuanLy(this);
            f.Show();
            this.Hide();
        }

        private void btnPhongBan_Click(object sender, EventArgs e)
        {
            FrmPhongBan f = new FrmPhongBan(this);
            f.Show();
            this.Hide();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            FrmChamCong f = new FrmChamCong(this);
            f.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
