using System;
using System.Drawing;
using System.Windows.Forms;
using Quanly.BLL;

namespace Quanly.GUI
{
    public partial class frmLogin : Form
    {
        private UserBLL bll = new UserBLL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Xóa thông báo cũ
            lblErrorUser.Text = "";
            lblErrorPass.Text = "";

            string user = txtUser.Text.Trim();
            string pass = txtPass.Text;
            bool isValid = true;

            // Kiểm tra User
            if (string.IsNullOrEmpty(user))
            {
                lblErrorUser.Text = "* Vui lòng nhập tài khoản";
                isValid = false;
            }
            else if (txtUser.Text.Contains(" "))
            {
                lblErrorUser.Text = "* Tài khoản không chứa khoảng cách";
                isValid = false;
            }
            else if (!user.Contains("@"))
            {
                lblErrorUser.Text = "* Phải là email (thiếu @)";
                isValid = false;
            }

            // Kiểm tra Password
            if (string.IsNullOrEmpty(pass))
            {
                lblErrorPass.Text = "* Vui lòng nhập mật khẩu";
                isValid = false;
            }

            if (!isValid) return;

            try
            {
                if (bll.Login(user, pass))
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form1 dashboard = new Form1();
                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    lblErrorUser.Text = "* Thông tin tài khoản không đúng";
                    lblErrorPass.Text = "* Vui lòng kiểm tra lại";
                    txtPass.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tự động xóa thông báo lỗi khi người dùng bắt đầu gõ lại
        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblErrorUser.Text = "";
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            lblErrorPass.Text = "";
        }
    }
}