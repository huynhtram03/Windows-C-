namespace WinFormsApp1.GUI
{
    partial class FrmSuaNhanVien
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();

            this.pnlContent = new System.Windows.Forms.Panel();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();

            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();

            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height = 60;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(110, 15);
            this.lblTitle.Text = "SỬA NHÂN VIÊN";

            this.pnlHeader.Controls.Add(this.lblTitle);

            // ================= CONTENT PANEL =================
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Location = new System.Drawing.Point(15, 75);
            this.pnlContent.Size = new System.Drawing.Size(390, 250);

            // ================= LABELS =================
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Text = "Tên nhân viên";

            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Text = "Tài khoản";

            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Text = "Mật khẩu";

            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Text = "Chức vụ";

            // ================= TEXTBOX =================
            this.txtTenNV.Location = new System.Drawing.Point(140, 22);
            this.txtTenNV.Size = new System.Drawing.Size(220, 27);

            this.txtTaiKhoan.Location = new System.Drawing.Point(140, 62);
            this.txtTaiKhoan.Size = new System.Drawing.Size(220, 27);

            this.txtMatKhau.Location = new System.Drawing.Point(140, 102);
            this.txtMatKhau.Size = new System.Drawing.Size(220, 27);
            this.txtMatKhau.UseSystemPasswordChar = true;

            // ================= COMBOBOX =================
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Location = new System.Drawing.Point(140, 142);
            this.cboChucVu.Size = new System.Drawing.Size(220, 28);

            // ================= BUTTON LƯU =================
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(140, 190);
            this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.Text = "💾 LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // ================= BUTTON HỦY =================
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(260, 190);
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.Text = "❌ HỦY";
            this.btnHuy.Click += (s, e) => this.Close();

            // ================= ADD CONTENT =================
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Controls.Add(this.label2);
            this.pnlContent.Controls.Add(this.label3);
            this.pnlContent.Controls.Add(this.label4);

            this.pnlContent.Controls.Add(this.txtTenNV);
            this.pnlContent.Controls.Add(this.txtTaiKhoan);
            this.pnlContent.Controls.Add(this.txtMatKhau);
            this.pnlContent.Controls.Add(this.cboChucVu);

            this.pnlContent.Controls.Add(this.btnLuu);
            this.pnlContent.Controls.Add(this.btnHuy);

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlContent);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa nhân viên";
            this.Load += new System.EventHandler(this.FrmSuaNhanVien_Load);

            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.ComboBox cboChucVu;

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
    }
}
