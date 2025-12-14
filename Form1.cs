using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Article28
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer tmGameLoop = new System.Windows.Forms.Timer();
        private List<PointF> snowflakes = new List<PointF>(); // hiệu ứng tuyết

        private PictureBox pbBasket = new PictureBox();
        private PictureBox pbChicken = new PictureBox();
        private PictureBox pbEgg = new PictureBox();
        private Label lblScore = new Label();

        private int score = 0;
        private bool gameOver = false;

        private int basketSpeed = 10;
        private int chickenSpeed = 4;
        private int yDeltaEgg = 4;

        private int xBasket, yBasket;
        private int xEgg, yEgg;
        private bool moveLeft = false, moveRight = false;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            this.Text = "Game Hứng Trứng";
            this.Size = new Size(900, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.KeyPreview = true;

            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Load += new EventHandler(Form1_Load);
        }

        // Vẽ gradient nền và hiệu ứng tuyết
        private void Form1_Paint(object? sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle,
                Color.LightSkyBlue, Color.MistyRose, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            // Vẽ tuyết
            foreach (var flake in snowflakes)
            {
                e.Graphics.FillEllipse(Brushes.White, flake.X, flake.Y, 5, 5);
            }
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Giỏ
            pbBasket.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBasket.Size = new Size(100, 80);
            pbBasket.BackColor = Color.Transparent;
            LoadImageTransparent(pbBasket, "Images/basket.png", Color.White);
            this.Controls.Add(pbBasket);

            // Gà
            pbChicken.SizeMode = PictureBoxSizeMode.StretchImage;
            pbChicken.Size = new Size(120, 120);
            pbChicken.BackColor = Color.Transparent;
            LoadImageTransparent(pbChicken, "Images/chicken.png", Color.White);
            pbChicken.Location = new Point(100, 120); // gà cao hơn
            this.Controls.Add(pbChicken);

            // Trứng
            pbEgg.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEgg.Size = new Size(35, 45);
            pbEgg.BackColor = Color.Transparent;
            LoadImageTransparent(pbEgg, "Images/egg_gold.png", Color.White);
            this.Controls.Add(pbEgg);

            // Label điểm
            lblScore.Font = new Font("Comic Sans MS", 28, FontStyle.Bold);
            lblScore.ForeColor = Color.DarkOrange;
            lblScore.AutoSize = true;
            lblScore.Location = new Point(20, 20);
            lblScore.BackColor = Color.Transparent;
            this.Controls.Add(lblScore);

            // Timer
            tmGameLoop.Interval = 20;
            tmGameLoop.Tick += new EventHandler(GameLoop_Tick);

            StartNewGame();
        }

        private void LoadImageTransparent(PictureBox pb, string path, Color transparentColor)
        {
            try
            {
                if (System.IO.File.Exists(path))
                {
                    Bitmap bmp = new Bitmap(path);
                    bmp = MakeColorTransparent(bmp, transparentColor, 30);
                    pb.Image = bmp;
                }
                else
                {
                    pb.BackColor = Color.Gray;
                }
            }
            catch
            {
                pb.BackColor = Color.Gray;
            }
        }

        private Bitmap MakeColorTransparent(Bitmap bmp, Color color, int tolerance)
        {
            Bitmap newBmp = new Bitmap(bmp.Width, bmp.Height);
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color px = bmp.GetPixel(x, y);
                    if (Math.Abs(px.R - color.R) <= tolerance &&
                        Math.Abs(px.G - color.G) <= tolerance &&
                        Math.Abs(px.B - color.B) <= tolerance)
                    {
                        newBmp.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }
                    else
                    {
                        newBmp.SetPixel(x, y, px);
                    }
                }
            }
            return newBmp;
        }

        private void StartNewGame()
        {
            score = 0;
            lblScore.Text = "Điểm: 0";
            gameOver = false;
            yDeltaEgg = 4;

            xBasket = (this.ClientSize.Width / 2) - (pbBasket.Width / 2);
            yBasket = this.ClientSize.Height - pbBasket.Height - 20;

            // Tạo tuyết rơi ban đầu
            snowflakes.Clear();
            for (int i = 0; i < 100; i++)
            {
                snowflakes.Add(new PointF(rnd.Next(0, this.ClientSize.Width), rnd.Next(0, this.ClientSize.Height)));
            }

            ResetEgg();
            tmGameLoop.Start();
        }

        private void ResetEgg()
        {
            yEgg = pbChicken.Bottom - 10;
            xEgg = pbChicken.Left + (pbChicken.Width / 2) - (pbEgg.Width / 2);
            pbEgg.Location = new Point(xEgg, yEgg);
            // Reset hình trứng vàng
            LoadImageTransparent(pbEgg, "Images/egg_gold.png", Color.White);
        }

        private void GameLoop_Tick(object? sender, EventArgs e)
        {
            if (gameOver) return;

            // Di chuyển giỏ
            if (moveLeft && xBasket > 5) xBasket -= basketSpeed;
            if (moveRight && xBasket < this.ClientSize.Width - pbBasket.Width - 5) xBasket += basketSpeed;
            pbBasket.Location = new Point(xBasket, yBasket);

            // Di chuyển gà
            pbChicken.Left += chickenSpeed;
            if (pbChicken.Left <= 0 || pbChicken.Left >= this.ClientSize.Width - pbChicken.Width)
                chickenSpeed = -chickenSpeed;

            // Trứng rơi
            yEgg += yDeltaEgg;
            pbEgg.Location = new Point(xEgg, yEgg);

            // Bắt trứng
            if (pbEgg.Bounds.IntersectsWith(pbBasket.Bounds))
            {
                score++;
                lblScore.Text = "Điểm: " + score;
                if (score % 5 == 0) yDeltaEgg += 1;
                ResetEgg();
            }

            // Trứng rơi ngoài giỏ => Game over và trứng vỡ
            if (yEgg > this.ClientSize.Height)
            {
                gameOver = true;

                try
                {
                    pbEgg.Image = Image.FromFile("Images/egg_broken.png");
                }
                catch
                {
                    pbEgg.BackColor = Color.Red;
                }

                tmGameLoop.Stop();
                MessageBox.Show($"Game Over! Điểm của bạn: {score}", "Kết thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tự động reset game sau thông báo
                StartNewGame();
            }

            // Cập nhật tuyết rơi
            for (int i = 0; i < snowflakes.Count; i++)
            {
                float x = snowflakes[i].X + (float)Math.Sin(Environment.TickCount / 500.0) * 1f;
                float y = snowflakes[i].Y + 1.5f;
                if (y > this.ClientSize.Height)
                    y = 0;
                snowflakes[i] = new PointF(x, y);
            }

            this.Invalidate(); // vẽ lại form
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = true;
            if (e.KeyCode == Keys.Right) moveRight = true;
            base.OnKeyDown(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) moveLeft = false;
            if (e.KeyCode == Keys.Right) moveRight = false;
            base.OnKeyUp(e);
        }
    }
}
