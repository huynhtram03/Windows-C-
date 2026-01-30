using System.Windows.Forms;

namespace Quanly.GUI
{
    partial class CustomerPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();

            // --- Form1 (Kích thước 950x650) ---
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.Text = "Hệ Thống Quản Lý Khách Hàng";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // lblHeader
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Size = new System.Drawing.Size(950, 60);
            this.lblHeader.Text = "QUẢN LÝ THÔNG TIN KHÁCH HÀNG";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // --- groupBoxInfo (Căn chỉnh lại toàn bộ bên trong) ---
            this.groupBoxInfo.Location = new System.Drawing.Point(20, 75);
            this.groupBoxInfo.Size = new System.Drawing.Size(730, 220);
            this.groupBoxInfo.BackColor = System.Drawing.Color.White;
            this.groupBoxInfo.Text = "Thông tin chi tiết";

            // Nhãn và Ô nhập liệu (Fix lỗi mất chữ/tràn lề)
            this.label1.Text = "Mã KH:"; this.label1.Location = new System.Drawing.Point(25, 45); this.label1.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(120, 42); this.txtID.Size = new System.Drawing.Size(300, 25);

            this.label2.Text = "Họ và tên:"; this.label2.Location = new System.Drawing.Point(25, 95); this.label2.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(120, 92); this.txtName.Size = new System.Drawing.Size(300, 25);

            this.label3.Text = "Giới tính:"; this.label3.Location = new System.Drawing.Point(25, 145); this.label3.AutoSize = true;
            this.cboGender.Location = new System.Drawing.Point(120, 142); this.cboGender.Size = new System.Drawing.Size(100, 25);
            this.cboGender.DropDownStyle = ComboBoxStyle.DropDownList;

            this.label4.Text = "Ngày sinh:"; this.label4.Location = new System.Drawing.Point(240, 145); this.label4.AutoSize = true;
            this.dtpBirthday.Location = new System.Drawing.Point(320, 142); this.dtpBirthday.Size = new System.Drawing.Size(100, 25);
            this.dtpBirthday.Format = DateTimePickerFormat.Short;

            // Hình ảnh
            this.picAvatar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.picAvatar.BorderStyle = BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(480, 25);
            this.picAvatar.Size = new System.Drawing.Size(220, 145);
            this.picAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            this.btnBrowse.Text = "📁 Chọn ảnh";
            this.btnBrowse.Location = new System.Drawing.Point(480, 175);
            this.btnBrowse.Size = new System.Drawing.Size(220, 30);
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);

            // Nút chức năng (Cột bên phải)
            int startX = 775, btnW = 145, btnH = 45;
            this.btnAdd.Text = "➕ THÊM"; this.btnAdd.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnAdd.ForeColor = System.Drawing.Color.White; this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(startX, 85); this.btnAdd.Size = new System.Drawing.Size(btnW, btnH);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnEdit.Text = "🔧 SỬA"; this.btnEdit.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnEdit.ForeColor = System.Drawing.Color.White; this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(startX, 140); this.btnEdit.Size = new System.Drawing.Size(btnW, btnH);
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);

            this.btnDelete.Text = "🗑 XÓA"; this.btnDelete.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnDelete.ForeColor = System.Drawing.Color.White; this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(startX, 195); this.btnDelete.Size = new System.Drawing.Size(btnW, btnH);
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.Text = "🔄 MỚI"; this.btnClear.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClear.ForeColor = System.Drawing.Color.White; this.btnClear.FlatStyle = FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(startX, 250); this.btnClear.Size = new System.Drawing.Size(btnW, btnH);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // --- dgvCustomer (Bảng dữ liệu) ---
            this.dgvCustomer.Location = new System.Drawing.Point(20, 310);
            this.dgvCustomer.Size = new System.Drawing.Size(900, 310);
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.RowTemplate.Height = 50;
            this.dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.CellClick += new DataGridViewCellEventHandler(this.dgvCustomer_CellClick);

            this.dgvCustomer.Columns.Clear();
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Ảnh"; imgCol.Name = "colAvatar"; imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom; imgCol.Width = 60;
            this.dgvCustomer.Columns.Add(imgCol);
            this.dgvCustomer.Columns.Add("colID", "Mã KH");
            this.dgvCustomer.Columns.Add("colName", "Họ tên");
            this.dgvCustomer.Columns.Add("colGender", "Phái");
            this.dgvCustomer.Columns.Add("colBirthday", "Ngày sinh");
            this.dgvCustomer.Columns.Add("image_path", "Path");
            this.dgvCustomer.Columns["image_path"].Visible = false;

            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(9, 132, 227);
            this.dgvCustomer.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer.ColumnHeadersHeight = 40;

            // Gom Controls
            this.groupBoxInfo.Controls.AddRange(new Control[] { label1, txtID, label2, txtName, label3, cboGender, label4, dtpBirthday, picAvatar, btnBrowse });
            this.Controls.AddRange(new Control[] { lblHeader, groupBoxInfo, btnAdd, btnEdit, btnDelete, btnClear, dgvCustomer });

            this.Load += new System.EventHandler(this.CustomerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        private DataGridView dgvCustomer;
        private TextBox txtID, txtName;
        private ComboBox cboGender;
        private DateTimePicker dtpBirthday;
        private PictureBox picAvatar;
        private Button btnBrowse, btnAdd, btnEdit, btnDelete, btnClear;
        private GroupBox groupBoxInfo;
        private Label label1, label2, label3, label4, lblHeader;
    }
}
