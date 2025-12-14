namespace Article22
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbGender;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.tBId = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();
            this.btAddNew = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // dgvEmployee
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 12);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.Size = new System.Drawing.Size(560, 240);
            this.dgvEmployee.TabIndex = 0;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);

            // Tạo cột
            this.dgvEmployee.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn()
            {
                Name = "colId",
                HeaderText = "Mã NV",
                Width = 80
            });
            this.dgvEmployee.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn()
            {
                Name = "colName",
                HeaderText = "Họ và tên",
                Width = 180
            });
            this.dgvEmployee.Columns.Add(new System.Windows.Forms.DataGridViewTextBoxColumn()
            {
                Name = "colAge",
                HeaderText = "Tuổi",
                Width = 60
            });
            this.dgvEmployee.Columns.Add(new System.Windows.Forms.DataGridViewCheckBoxColumn()
            {
                Name = "colGender",
                HeaderText = "Nam?",
                Width = 60
            });

            // Labels
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 265);
            this.lbId.Text = "Mã NV";

            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(200, 265);
            this.lbName.Text = "Họ và tên";

            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(12, 310);
            this.lbAge.Text = "Tuổi";

            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(200, 310);
            this.lbGender.Text = "Nam?";

            // TextBoxes
            this.tBId.Location = new System.Drawing.Point(12, 283);
            this.tBId.Size = new System.Drawing.Size(160, 23);

            this.tBName.Location = new System.Drawing.Point(200, 283);
            this.tBName.Size = new System.Drawing.Size(260, 23);

            this.tBAge.Location = new System.Drawing.Point(12, 328);
            this.tBAge.Size = new System.Drawing.Size(100, 23);

            // CheckBox
            this.ckGender.Location = new System.Drawing.Point(200, 328);
            this.ckGender.Size = new System.Drawing.Size(18, 24);

            // Buttons
            this.btAddNew.Location = new System.Drawing.Point(12, 370);
            this.btAddNew.Size = new System.Drawing.Size(100, 30);
            this.btAddNew.Text = "Thêm";
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            this.btDelete.Location = new System.Drawing.Point(132, 370);
            this.btDelete.Size = new System.Drawing.Size(100, 30);
            this.btDelete.Text = "Xóa";
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            this.btnThoat.Location = new System.Drawing.Point(472, 370);
            this.btnThoat.Size = new System.Drawing.Size(100, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.tBAge);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
