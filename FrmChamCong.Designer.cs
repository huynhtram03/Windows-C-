using System;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    partial class FrmChamCong
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvChamCong;
        private Panel pnlHeader;
        private Label lblTitle;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThoat;

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
            this.components = new System.ComponentModel.Container();
            this.dgvChamCong = new DataGridView();
            this.pnlHeader = new Panel();
            this.lblTitle = new Label();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // ================= HEADER =================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.pnlHeader.Dock = DockStyle.Top;
            this.pnlHeader.Height = 70;

            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(200, 15);
            this.lblTitle.Text = "CHẤM CÔNG NHÂN VIÊN";

            this.pnlHeader.Controls.Add(this.lblTitle);

            // ================= DATAGRIDVIEW =================
            this.dgvChamCong.Location = new System.Drawing.Point(20, 90);
            this.dgvChamCong.Size = new System.Drawing.Size(810, 400);
            this.dgvChamCong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.ReadOnly = true;

            // ================= BUTTONS =================
            this.btnThem.Location = new System.Drawing.Point(150, 510);
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.Text = "THÊM";
            this.btnThem.Click += BtnThem_Click;

            this.btnSua.Location = new System.Drawing.Point(270, 510);
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.Text = "SỬA";
            this.btnSua.Click += BtnSua_Click;

            this.btnXoa.Location = new System.Drawing.Point(390, 510);
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.Text = "XÓA";
            this.btnXoa.Click += BtnXoa_Click;

            this.btnThoat.Location = new System.Drawing.Point(700, 510);
            this.btnThoat.Size = new System.Drawing.Size(120, 40);
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.BackColor = System.Drawing.Color.DarkGray;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Click += BtnThoat_Click;

            // ================= FORM =================
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThoat);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Chấm công nhân viên";

            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
