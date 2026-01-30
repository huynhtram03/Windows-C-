using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quanly.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupSideMenuButtons();
            SetupDashboard();
            // Mặc định hiển thị bảng mẫu hoặc trang chủ khi vừa mở app
            LoadSampleData();
        }

        private void SetupSideMenuButtons()
        {
            // Thêm sự kiện Click cho các nút menu
            Button btnOrders = CreateMenuButton("Đơn hàng", 220);
            Button btnProducts = CreateMenuButton("Sản phẩm", 160);
            Button btnCustomers = CreateMenuButton("Khách hàng", 100);

            // Đăng ký sự kiện Click để mở trang
            btnCustomers.Click += (s, e) => OpenChildForm(new CustomerPage());
            btnProducts.Click += (s, e) => OpenChildForm(new ProductPage());
            btnOrders.Click += (s, e) => OpenChildForm(new OrderPage());

            sideMenu.Controls.Add(btnOrders);
            sideMenu.Controls.Add(btnProducts);
            sideMenu.Controls.Add(btnCustomers);
        }

        // HÀM QUAN TRỌNG: Dùng để nhúng Form con vào Form chính
        private void OpenChildForm(Form childForm)
        {
            // Ẩn bảng và các thẻ thống kê hiện tại để lấy chỗ trống hiển thị trang mới
            dgvCustomers.Visible = false;
            flowLayoutPanelCards.Visible = false;

            // Thiết lập Form con làm Control nhúng
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Xóa các Control cũ đang "chiếm đóng" vùng nội dung nếu có
            // Lưu ý: Nếu bạn có panelContent riêng thì add vào đó, 
            // ở đây tôi add trực tiếp vào Controls của Form1 (vùng trung tâm)
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void SetupDashboard()
        {
            flowLayoutPanelCards.Controls.Add(CreateCard("Tổng khách hàng", "1,250", Color.Gold));
            flowLayoutPanelCards.Controls.Add(CreateCard("Khách hàng VIP", "45", Color.FromArgb(0, 150, 136)));
            flowLayoutPanelCards.Controls.Add(CreateCard("Doanh thu tháng", "120M", Color.FromArgb(255, 128, 0)));
        }

        private Button CreateMenuButton(string text, int top)
        {
            return new Button
            {
                Text = text,
                Location = new Point(0, top),
                Size = new Size(200, 50),
                FlatStyle = FlatStyle.Flat,
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(20, 0, 0, 0),
                Font = new Font("Segoe UI", 10),
                Cursor = Cursors.Hand, // Thêm bàn tay khi rê chuột
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = Color.FromArgb(45, 45, 81) }
            };
        }

        private Panel CreateCard(string title, string value, Color color)
        {
            Panel card = new Panel { Size = new Size(220, 100), BackColor = Color.FromArgb(45, 45, 81), Margin = new Padding(0, 0, 20, 0) };
            Panel line = new Panel { Size = new Size(220, 4), Dock = DockStyle.Bottom, BackColor = color };
            Label lblTitle = new Label { Text = title, ForeColor = Color.LightGray, Location = new Point(15, 15), AutoSize = true, Font = new Font("Segoe UI", 9) };
            Label lblValue = new Label { Text = value, ForeColor = Color.White, Location = new Point(15, 40), AutoSize = true, Font = new Font("Segoe UI", 16, FontStyle.Bold) };
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            card.Controls.Add(line);
            return card;
        }

        private void LoadSampleData()
        {
            // Chỉ chạy nếu GridView chưa có cột nào
            if (dgvCustomers.Columns.Count == 0)
            {
                dgvCustomers.Columns.Add("ID", "Mã KH");
                dgvCustomers.Columns.Add("Name", "Tên Khách Hàng");
                dgvCustomers.Columns.Add("Type", "Hạng Thành Viên");
                dgvCustomers.Columns.Add("Spent", "Tổng Chi Tiêu");
            }

            dgvCustomers.Rows.Clear();
            dgvCustomers.Rows.Add("KH001", "Nguyễn Văn A", "Kim Cương", "150.000.000đ");
            dgvCustomers.Rows.Add("KH002", "Trần Thị B", "Vàng", "45.500.000đ");
        }
    }
}