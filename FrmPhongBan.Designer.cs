namespace WinFormsApp1.GUI
{
    partial class FrmPhongBan
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private GroupBox grpInput;
        private Label label1;
        private TextBox txtTenPB;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;
        private DataGridView dgvPB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvPB = new DataGridView();
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.grpInput = new GroupBox();
            this.label1 = new Label();
            this.txtTenPB = new TextBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 90;

            this.lblTitle.AutoSize = false;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG BAN";

            this.pnlHeader.Controls.Add(this.lblTitle);

            // ================= GROUP INPUT =================
            this.grpInput.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.grpInput.ForeColor = System.Drawing.Color.Black;
            this.grpInput.Location = new System.Drawing.Point(20, 100);
            this.grpInput.Size = new System.Drawing.Size(810, 130);
            this.grpInput.Text = "Thông tin phòng ban";

            this.label1.Text = "Tên PB:";
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.AutoSize = true;

            this.txtTenPB.Location = new System.Drawing.Point(160, 45);
            this.txtTenPB.Size = new System.Drawing.Size(250, 30);

            this.btnThem.Location = new System.Drawing.Point(450, 40);
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Location = new System.Drawing.Point(560, 40);
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Location = new System.Drawing.Point(670, 40);
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Controls.Add(this.txtTenPB);
            this.grpInput.Controls.Add(this.btnThem);
            this.grpInput.Controls.Add(this.btnSua);
            this.grpInput.Controls.Add(this.btnXoa);

            // ================= DATAGRIDVIEW =================
            this.dgvPB.BackgroundColor = System.Drawing.Color.White;
            this.dgvPB.Location = new System.Drawing.Point(20, 250);
            this.dgvPB.Size = new System.Drawing.Size(810, 350);
            this.dgvPB.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPB.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPB.ReadOnly = true;
            this.dgvPB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellClick);

            // ================= BUTTON THOÁT =================
            this.btnThoat.Location = new System.Drawing.Point(700, 620);
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(850, 700);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.dgvPB);
            this.Controls.Add(this.btnThoat);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng ban";
            this.Load += new System.EventHandler(this.FrmPhongBan_Load);

            this.ResumeLayout(false);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
        }
    }
}
