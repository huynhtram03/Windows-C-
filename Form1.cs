using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Article27
{
    public partial class Form1 : Form
    {
        PictureBox pbBasket = new PictureBox();

        int xBasket = 300; 
        int yBasket = 500; 
        int xDelta = 30;   

        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.KeyDown += Form1_KeyDown;

            this.KeyPreview = true;
            this.DoubleBuffered = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(900, 700);

            // ================================
            // 1. Đường dẫn ảnh
            // ================================
            string imageFolderPath = Path.Combine(Application.StartupPath, "Images");
            string imagePath = Path.Combine(imageFolderPath, "basket.png");

            // ================================
            // 2. Setup PictureBox
            // ================================
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(120, 90);
            pbBasket.BackColor = Color.Transparent;

            this.Controls.Add(pbBasket);

            pbBasket.Location = new Point(xBasket, yBasket);

            // ================================
            // 3. Load ảnh + Xoá nền trắng
            // ================================
            if (File.Exists(imagePath))
            {
                Bitmap original = new Bitmap(imagePath);
                pbBasket.Image = RemoveBackground(original);
            }
            else
            {
                pbBasket.BackColor = Color.Red;
                MessageBox.Show("❌ Không tìm thấy ảnh:\n" + imagePath);
            }

            pbBasket.BringToFront();
        }

        // =====================================================
        // Xóa nền trắng khỏi ảnh basket.png (convert sang trong suốt)
        // =====================================================
        private Bitmap RemoveBackground(Bitmap bmp)
        {
            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);

            for (int y = 0; y < bmp.Height; y++)
            {
                for (int x = 0; x < bmp.Width; x++)
                {
                    Color px = bmp.GetPixel(x, y);

                    // Phát hiện màu trắng (hoặc gần trắng)
                    if (px.R > 240 && px.G > 240 && px.B > 240)
                    {
                        newBmp.SetPixel(x, y, Color.FromArgb(0, px)); // alpha = 0
                    }
                    else
                    {
                        newBmp.SetPixel(x, y, px);
                    }
                }
            }

            return newBmp;
        }

        // =================================================
        // Di chuyển giỏ trái phải
        // =================================================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right &&
                xBasket < this.ClientSize.Width - pbBasket.Width)
            {
                xBasket += xDelta;
            }
            else if (e.KeyCode == Keys.Left && xBasket > 0)
            {
                xBasket -= xDelta;
            }

            pbBasket.Location = new Point(xBasket, yBasket);
        }
    }
}
