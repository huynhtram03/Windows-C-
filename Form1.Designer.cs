namespace Article20
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbTuoi;
        private System.Windows.Forms.CheckBox chkNam;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTuoi;
        private System.Windows.Forms.Label lblGioiTinh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbTuoi = new System.Windows.Forms.TextBox();
            this.chkNam = new System.Windows.Forms.CheckBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTuoi = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();

            // dgvNhanVien
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Location = new System.Drawing.Point(12, 12);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.Size = new System.Drawing.Size(560, 200);
            this.dgvNhanVien.TabIndex = 0;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);

            // CREATE COLUMNS (explicitly) 
            var colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colMa.HeaderText = "Mã";
            colMa.Name = "colMa";
            colMa.ValueType = typeof(string);

            var colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTen.HeaderText = "Tên";
            colTen.Name = "colTen";
            colTen.ValueType = typeof(string);

            var colTuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colTuoi.HeaderText = "Tuổi";
            colTuoi.Name = "colTuoi";
            colTuoi.ValueType = typeof(int);

            var colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colGioiTinh.HeaderText = "Nam?";
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ValueType = typeof(bool);

            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                colMa, colTen, colTuoi, colGioiTinh
            });

            // Labels + TextBoxes
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(12, 225);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(30, 15);
            this.lblMa.Text = "Mã:";

            this.tbMa.Location = new System.Drawing.Point(60, 222);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(150, 23);

            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(230, 225);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(33, 15);
            this.lblTen.Text = "Tên:";

            this.tbTen.Location = new System.Drawing.Point(270, 222);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(200, 23);

            this.lblTuoi.AutoSize = true;
            this.lblTuoi.Location = new System.Drawing.Point(12, 260);
            this.lblTuoi.Name = "lblTuoi";
            this.lblTuoi.Size = new System.Drawing.Size(34, 15);
            this.lblTuoi.Text = "Tuổi:";

            this.tbTuoi.Location = new System.Drawing.Point(60, 257);
            this.tbTuoi.Name = "tbTuoi";
            this.tbTuoi.Size = new System.Drawing.Size(150, 23);

            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Location = new System.Drawing.Point(230, 260);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(58, 15);
            this.lblGioiTinh.Text = "Giới tính:";

            this.chkNam.Location = new System.Drawing.Point(300, 256);
            this.chkNam.Name = "chkNam";
            this.chkNam.Size = new System.Drawing.Size(80, 24);
            this.chkNam.Text = "Nam";
            this.chkNam.UseVisualStyleBackColor = true;

            // Buttons
            this.btnThem.Location = new System.Drawing.Point(12, 300);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnXoa.Location = new System.Drawing.Point(130, 300);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.Location = new System.Drawing.Point(250, 300);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.lblMa);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.lblTuoi);
            this.Controls.Add(this.tbTuoi);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.chkNam);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.Name = "Form1";
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}
