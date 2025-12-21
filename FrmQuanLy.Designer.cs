namespace WinFormsApp1.GUI
{
    partial class FrmQuanLy
    {
        private System.ComponentModel.IContainer components = null;

        private DataGridView dgvNV;
        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox grpInput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;

        private TextBox txtTenNV;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;

        private ComboBox cboChucVu;

        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            dgvNV = new DataGridView();
            pnlHeader = new Panel();
            lblTitle = new Label();
            grpInput = new GroupBox();

            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();

            txtTenNV = new TextBox();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            cboChucVu = new ComboBox();

            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();

            SuspendLayout();

            // header
            pnlHeader.BackColor = System.Drawing.Color.SteelBlue;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 70;
            pnlHeader.Controls.Add(lblTitle);

            lblTitle.AutoSize = true;
            lblTitle.Text = "QUẢN LÝ NHÂN VIÊN";
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(260, 20);

            // group input
            grpInput.Text = "Thông tin nhân viên";
            grpInput.Location = new System.Drawing.Point(20, 90);
            grpInput.Size = new System.Drawing.Size(800, 200);

            // label + textbox
            label1.Text = "Tên NV";
            label1.Location = new System.Drawing.Point(20, 40);

            label2.Text = "Tài khoản";
            label2.Location = new System.Drawing.Point(20, 80);

            label3.Text = "Mật khẩu";
            label3.Location = new System.Drawing.Point(20, 120);

            label4.Text = "Chức vụ";
            label4.Location = new System.Drawing.Point(400, 40);

            txtTenNV.Location = new System.Drawing.Point(130, 35);
            txtTenNV.Size = new System.Drawing.Size(220, 30);

            txtTaiKhoan.Location = new System.Drawing.Point(130, 75);
            txtTaiKhoan.Size = new System.Drawing.Size(220, 30);

            txtMatKhau.Location = new System.Drawing.Point(130, 115);
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhau.Size = new System.Drawing.Size(220, 30);

            cboChucVu.Location = new System.Drawing.Point(470, 35);
            cboChucVu.Size = new System.Drawing.Size(220, 30);

            btnThem.Text = "Thêm";
            btnThem.Location = new System.Drawing.Point(470, 100);
            btnThem.Size = new System.Drawing.Size(70, 40);
            btnThem.Click += btnThem_Click;

            btnSua.Text = "Sửa";
            btnSua.Location = new System.Drawing.Point(550, 100);
            btnSua.Size = new System.Drawing.Size(70, 40);
            btnSua.Click += btnSua_Click;

            btnXoa.Text = "Xóa";
            btnXoa.Location = new System.Drawing.Point(630, 100);
            btnXoa.Size = new System.Drawing.Size(70, 40);
            btnXoa.Click += btnXoa_Click;

            grpInput.Controls.Add(label1);
            grpInput.Controls.Add(label2);
            grpInput.Controls.Add(label3);
            grpInput.Controls.Add(label4);
            grpInput.Controls.Add(txtTenNV);
            grpInput.Controls.Add(txtTaiKhoan);
            grpInput.Controls.Add(txtMatKhau);
            grpInput.Controls.Add(cboChucVu);
            grpInput.Controls.Add(btnThem);
            grpInput.Controls.Add(btnSua);
            grpInput.Controls.Add(btnXoa);

            dgvNV.Location = new System.Drawing.Point(20, 300);
            dgvNV.Size = new System.Drawing.Size(800, 280);

            btnThoat.Text = "Thoát";
            btnThoat.Location = new System.Drawing.Point(700, 600);
            btnThoat.Size = new System.Drawing.Size(120, 40);
            btnThoat.Click += btnThoat_Click;

            ClientSize = new System.Drawing.Size(850, 650);
            Controls.Add(pnlHeader);
            Controls.Add(grpInput);
            Controls.Add(dgvNV);
            Controls.Add(btnThoat);

            Load += FrmQuanLy_Load;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";

            ResumeLayout(false);
        }
    }
}
