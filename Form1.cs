using System;
using System.Drawing;
using System.Windows.Forms;

namespace Article25
{
    public partial class Form1 : Form
    {
        // ================================
        // Thông số bóng
        // ================================
        private int xBall;
        private int yBall;
        private int xDelta = 5;
        private int yDelta = 5;
        private int ballSize = 60;

        // Timer game loop (chỉ rõ namespace)
        private System.Windows.Forms.Timer tmGame;

        public Form1()
        {
            InitializeComponent();

            // Giảm nhấp nháy khi vẽ
            this.DoubleBuffered = true;

            // Tự tạo timer thay vì dùng Designer
            tmGame = new System.Windows.Forms.Timer();
            tmGame.Interval = 20;       // ~50 FPS
            tmGame.Tick += TmGame_Tick;

            this.Load += Form1_Load;    // Bắt sự kiện load form
        }

        // ================================
        // Khi Form load
        // ================================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Đặt bóng chính giữa cửa sổ
            xBall = (this.ClientSize.Width - ballSize) / 2;
            yBall = (this.ClientSize.Height - ballSize) / 2;

            tmGame.Start(); // bắt đầu game loop
        }

        // ================================
        // Game loop - xử lý chuyển động + va chạm
        // ================================
        private void TmGame_Tick(object sender, EventArgs e)
        {
            // Cập nhật vị trí
            xBall += xDelta;
            yBall += yDelta;

            // Va chạm trục X
            if (xBall <= 0)
            {
                xBall = 0;
                xDelta = Math.Abs(xDelta);
            }
            else if (xBall + ballSize >= this.ClientSize.Width)
            {
                xBall = this.ClientSize.Width - ballSize;
                xDelta = -Math.Abs(xDelta);
            }

            // Va chạm trục Y
            if (yBall <= 0)
            {
                yBall = 0;
                yDelta = Math.Abs(yDelta);
            }
            else if (yBall + ballSize >= this.ClientSize.Height)
            {
                yBall = this.ClientSize.Height - ballSize;
                yDelta = -Math.Abs(yDelta);
            }

            // Yêu cầu vẽ lại
            this.Invalidate();
        }

        // ================================
        // Vẽ bóng
        // ================================
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                new Rectangle(xBall, yBall, ballSize, ballSize),
                Color.OrangeRed,
                Color.Yellow,
                45f))
            {
                g.FillEllipse(brush, xBall, yBall, ballSize, ballSize);

                using (var pen = new Pen(Color.DarkOrange, 2))
                {
                    g.DrawEllipse(pen, xBall, yBall, ballSize, ballSize);
                }
            }
        }

        // ================================
        // Tạm dừng game
        // ================================
        public void PauseGame()
        {
            if (tmGame != null && tmGame.Enabled)
                tmGame.Stop();
        }

        // Tiếp tục game
        public void ResumeGame()
        {
            if (tmGame != null && !tmGame.Enabled)
                tmGame.Start();
        }

        // ================================
        // Giải phóng khi đóng form
        // ================================
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (tmGame != null)
            {
                tmGame.Tick -= TmGame_Tick;
                tmGame.Stop();
                tmGame.Dispose();
                tmGame = null;
            }

            base.OnFormClosing(e);
        }
    }
}
