using System.Drawing;
using System.Windows.Forms;

namespace Quanly.GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel searchWrapper;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel lineAccent;
        private System.Windows.Forms.Label lblSectionTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvAlternatingStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.sideMenu = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Panel();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblLogo = new System.Windows.Forms.Label();
            this.searchWrapper = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lineAccent = new System.Windows.Forms.Panel();
            this.lblSectionTitle = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();

            // ---------------------------------------------------------
            // SIDE MENU - Deep Black
            // ---------------------------------------------------------
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(15, 15, 15);
            this.sideMenu.Controls.Add(this.lblLogo);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Width = 260;

            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lblLogo.Height = 150;
            this.lblLogo.Text = "✧ LUXURY\nJEWELRY";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ---------------------------------------------------------
            // HEADER - Pure White
            // ---------------------------------------------------------
            this.header.BackColor = System.Drawing.Color.White;
            this.header.Controls.Add(this.lblSectionTitle);
            this.header.Controls.Add(this.btnMinimize);
            this.header.Controls.Add(this.btnExit);
            this.header.Controls.Add(this.searchWrapper);
            this.header.Controls.Add(this.lineAccent);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Height = 80;

            this.lineAccent.BackColor = System.Drawing.Color.FromArgb(212, 175, 55);
            this.lineAccent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lineAccent.Height = 2;

            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblSectionTitle.Location = new System.Drawing.Point(420, 24);
            this.lblSectionTitle.Text = "QUẢN LÝ KHÁCH HÀNG";

            // Control Buttons
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(232, 17, 35);
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExit.Text = "✕";
            this.btnExit.Width = 60;
            this.btnExit.Click += (s, e) => Application.Exit();

            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.Text = "—";
            this.btnMinimize.Width = 60;
            this.btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Search Box
            this.searchWrapper.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.searchWrapper.Location = new System.Drawing.Point(30, 20);
            this.searchWrapper.Size = new System.Drawing.Size(350, 40);
            this.searchWrapper.Controls.Add(this.txtSearch);

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.txtSearch.Location = new System.Drawing.Point(15, 10);
            this.txtSearch.Size = new System.Drawing.Size(320, 25);
            this.txtSearch.Text = "Tìm kiếm...";

            // ---------------------------------------------------------
            // MAIN CONTAINER
            // ---------------------------------------------------------
            this.mainContainer.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.mainContainer.Controls.Add(this.dgvCustomers);
            this.mainContainer.Controls.Add(this.flowLayoutPanelCards);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Padding = new System.Windows.Forms.Padding(30);

            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelCards.Height = 120;

            // ---------------------------------------------------------
            // DATAGRIDVIEW
            // ---------------------------------------------------------
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.EnableHeadersVisualStyles = false;

            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(212, 175, 55);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.dgvCustomers.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvCustomers.ColumnHeadersHeight = 60;

            dgvCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            dgvCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(252, 248, 232);
            dgvCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(184, 134, 11);
            this.dgvCustomers.DefaultCellStyle = dgvCellStyle;
            this.dgvCustomers.RowTemplate.Height = 55;

            // ---------------------------------------------------------
            // FULL SCREEN FORM SETTINGS
            // ---------------------------------------------------------
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Thiết lập kích thước full màn hình
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            // Nếu bạn muốn lấy toàn bộ diện tích màn hình (đè lên cả Taskbar):
            // this.Bounds = Screen.PrimaryScreen.Bounds; 

            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sideMenu);

            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}