using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class FrmDashboard : Form
    {
        private Panel pnlHeader;
        private Label lblTitle;
        private Panel pnlMenu;
        private FlowLayoutPanel pnlContent;

        private Button btnQuanLyNV;
        private Button btnPhongBan;
        private Button btnChamCong;
        private Button btnExit;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // === FORM ===
            this.ClientSize = new Size(1300, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.FromArgb(245, 247, 250);

            // === HEADER ===
            pnlHeader = new Panel();
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 100;
            pnlHeader.BackColor = Color.FromArgb(0, 120, 215);

            lblTitle = new Label();
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Text = "HỆ THỐNG QUẢN LÝ NHÂN VIÊN NGÂN HÀNG";
            pnlHeader.Controls.Add(lblTitle);

            // === MENU LEFT ===
            pnlMenu = new Panel();
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Width = 250;
            pnlMenu.BackColor = Color.FromArgb(45, 62, 80);

            btnQuanLyNV = CreateMenuButton("🧑‍💼 Quản lý nhân viên", BtnQuanLyNV_Click);
            btnPhongBan = CreateMenuButton("🏢 Quản lý phòng ban", BtnPhongBan_Click);
            btnChamCong = CreateMenuButton("🕒 Chấm công", BtnChamCong_Click);
            btnExit = CreateMenuButton("❌ Thoát", BtnExit_Click);

            pnlMenu.Controls.AddRange(new Control[] { btnQuanLyNV, btnPhongBan, btnChamCong, btnExit });

            // === CONTENT PANEL ===
            pnlContent = new FlowLayoutPanel();
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);
            pnlContent.Padding = new Padding(20);
            pnlContent.AutoScroll = true;
            pnlContent.FlowDirection = FlowDirection.LeftToRight;
            pnlContent.WrapContents = true;

            AddDashboardCards();

            // === ADD CONTROLS ===
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlMenu);
            this.Controls.Add(pnlHeader);

            this.ResumeLayout(false);
        }

        // ================== TẠO BUTTON MENU ==================
        private Button CreateMenuButton(string text, EventHandler clickEvent)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn.BackColor = Color.FromArgb(45, 62, 80);
            btn.ForeColor = Color.White;
            btn.Size = new Size(230, 60);
            btn.Margin = new Padding(10, 20, 10, 0);
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) => btn.BackColor = Color.FromArgb(70, 90, 110);
            btn.MouseLeave += (s, e) => btn.BackColor = Color.FromArgb(45, 62, 80);

            btn.Click += clickEvent;
            return btn;
        }

        // ================== DASHBOARD CARDS ==================
        private void AddDashboardCards()
        {
            string[] titles = { "Tổng nhân viên", "Phòng ban", "Chấm công hôm nay", "Nhân viên nghỉ phép", "Dự án đang chạy", "Tổng lương tháng" };
            string[] values = { "120", "8", "115", "5", "3", "1.250.000.000" };
            Color[] colors = {
                Color.FromArgb(52, 152, 219),
                Color.FromArgb(26, 188, 156),
                Color.FromArgb(241, 196, 15),
                Color.FromArgb(231, 76, 60),
                Color.FromArgb(155, 89, 182),
                Color.FromArgb(230, 126, 34)
            };

            for (int i = 0; i < titles.Length; i++)
            {
                Panel card = new Panel();
                card.Size = new Size(300, 150);
                card.BackColor = colors[i];
                card.Padding = new Padding(15);
                card.Margin = new Padding(10);
                card.Cursor = Cursors.Hand;

                // Bo góc
                card.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, card.Width, card.Height, 20, 20));

                // Hover effect
                card.MouseEnter += (s, e) => card.BackColor = ControlPaint.Light(colors[i], 0.2f);
                card.MouseLeave += (s, e) => card.BackColor = colors[i];

                Label lblTitle = new Label();
                lblTitle.Text = titles[i];
                lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                lblTitle.ForeColor = Color.White;
                lblTitle.Location = new Point(10, 10);
                lblTitle.AutoSize = true;

                Label lblValue = new Label();
                lblValue.Text = values[i];
                lblValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
                lblValue.ForeColor = Color.White;
                lblValue.Location = new Point(10, 50);
                lblValue.AutoSize = true;

                card.Controls.Add(lblTitle);
                card.Controls.Add(lblValue);

                pnlContent.Controls.Add(card);
            }
        }

        // ================== BUTTON CLICK ==================
        private void BtnQuanLyNV_Click(object sender, EventArgs e) => MessageBox.Show("Chuyển sang Quản lý nhân viên");
        private void BtnPhongBan_Click(object sender, EventArgs e) => MessageBox.Show("Chuyển sang Quản lý phòng ban");
        private void BtnChamCong_Click(object sender, EventArgs e) => MessageBox.Show("Chuyển sang Chấm công");
        private void BtnExit_Click(object sender, EventArgs e) => this.Close();

        // ================== HELPER: Bo Góc ==================
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
    }
}
