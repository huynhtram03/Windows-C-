using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article23
{
    public partial class Form1 : Form
    {
        // Khai báo PictureBox và tọa độ x, y dùng chung
        PictureBox pb = new PictureBox();
        int x = 50; // Đặt mặc định 50 để ảnh không dính sát mép
        int y = 50;

        public Form1()
        {
            InitializeComponent();
        }

        // Sự kiện khi nhấn nút File...
        private void btFile_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại chọn file ảnh
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(100, 100);
                pb.Location = new Point(x, y);

                // Gán đường dẫn file vừa chọn
                pb.ImageLocation = open.FileName;

                // Nếu chưa có PictureBox trên Form thì thêm vào
                if (!this.Controls.Contains(pb))
                {
                    this.Controls.Add(pb);
                }
            }
        }

        // Nhấn nút sang trái
        private void btLeft_Click(object sender, EventArgs e)
        {
            x -= 10;
            pb.Location = new Point(x, y);
        }

        // Nhấn nút sang phải
        private void btRight_Click(object sender, EventArgs e)
        {
            x += 10;
            pb.Location = new Point(x, y);
        }
    }
}