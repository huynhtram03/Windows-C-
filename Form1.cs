using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1.GUI
{
    public partial class Form1 : Form
    {
        // ===== SNOW CLASS =====
        class Snow
        {
            public float X, Y, Speed, Size;
        }

        private readonly List<Snow> snowflakes = new();
        private readonly Random rnd = new();

        public Form1()
        {
            InitializeComponent();
            BoGoc(panelCard, 25);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            snowflakes.Clear();
            for (int i = 0; i < 60; i++)
            {
                snowflakes.Add(new Snow
                {
                    X = rnd.Next(Width),
                    Y = rnd.Next(Height),
                    Speed = 1 + (float)rnd.NextDouble() * 2,
                    Size = 2 + (float)rnd.NextDouble() * 3
                });
            }
            snowTimer.Start();
        }

        private void snowTimer_Tick(object sender, EventArgs e)
        {
            foreach (var s in snowflakes)
            {
                s.Y += s.Speed;
                if (s.Y > Height)
                {
                    s.Y = -10;
                    s.X = rnd.Next(Width);
                }
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using LinearGradientBrush bg = new(
                ClientRectangle,
                Color.FromArgb(225, 245, 255),
                Color.FromArgb(170, 220, 255),
                LinearGradientMode.Vertical);

            e.Graphics.FillRectangle(bg, ClientRectangle);

            using Brush snow = new SolidBrush(Color.White);
            foreach (var s in snowflakes)
                e.Graphics.FillEllipse(snow, s.X, s.Y, s.Size, s.Size);
        }

        private void BoGoc(Control c, int radius)
        {
            GraphicsPath path = new();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(c.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(c.Width - radius, c.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, c.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            c.Region = new Region(path);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đăng nhập thành công ✨", "LOGIN",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }
    }
}
