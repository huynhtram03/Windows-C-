using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Article26
{
    public partial class Form1 : Form
    {
        PictureBox pbEgg = new PictureBox();
        System.Windows.Forms.Timer tmEgg = new System.Windows.Forms.Timer();

        int xEgg = 300;
        int yEgg = 0;
        int yDelta = 4;
        bool isBroken = false;

        Image imgEgg;
        Image imgEggBroken;

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string imageFolderPath = Path.Combine(Application.StartupPath, "Images");

            try
            {
                imgEgg = Image.FromFile(Path.Combine(imageFolderPath, "egg_gold.png"));
                imgEggBroken = Image.FromFile(Path.Combine(imageFolderPath, "egg_gold_broken.png"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải ảnh: {ex.Message}");
                return;
            }

            // --- THIẾT LẬP ĐỂ XOÁ NỀN TRẮNG ---
            pbEgg.BackColor = Color.Transparent; // Đặt màu nền trong suốt
            pbEgg.Parent = this;                // Quan trọng: Gán Parent là Form để nhận độ trong suốt

            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(100, 100);
            pbEgg.Location = new Point(xEgg, yEgg);
            pbEgg.Image = imgEgg;

            tmEgg.Interval = 10;
            tmEgg.Tick += tmEgg_Tick;
            tmEgg.Start();
        }

        private void tmEgg_Tick(object sender, EventArgs e)
        {
            if (isBroken) return;

            yEgg += yDelta;

            if (yEgg >= this.ClientSize.Height - pbEgg.Height)
            {
                yEgg = this.ClientSize.Height - pbEgg.Height;
                pbEgg.Image = imgEggBroken;
                isBroken = true;
                tmEgg.Stop();
            }

            pbEgg.Location = new Point(xEgg, yEgg);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                yEgg = 0;
                isBroken = false;
                pbEgg.Image = imgEgg;
                tmEgg.Start();
            }
        }
    }
}