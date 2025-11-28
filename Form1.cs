using Article_01;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Example01
{
    public partial class Form1 : Form
    {
        private readonly string path = @"D:\form.xml";
        private InfoWindows iw = new InfoWindows();

        public Form1()
        {
            InitializeComponent();
            this.LocationChanged += Form1_LocationChanged;
        }

        // -------- WRITE XML --------
        private void Write(InfoWindows data)
        {
            XmlSerializer writer = new XmlSerializer(typeof(InfoWindows));
            using StreamWriter file = new StreamWriter(path);
            writer.Serialize(file, data);
        }

        // -------- READ XML --------
        private InfoWindows Read()
        {
            try
            {
                if (!File.Exists(path))
                    return new InfoWindows();

                XmlSerializer reader = new XmlSerializer(typeof(InfoWindows));
                using StreamReader file = new StreamReader(path);
                return (reader.Deserialize(file) as InfoWindows) ?? new InfoWindows();
            }
            catch
            {
                return new InfoWindows();
            }
        }

        // -------- LOAD FORM --------
        private void Form1_Load(object sender, EventArgs e)
        {
            iw = Read();

            if (iw.Width > 200) Width = iw.Width;
            if (iw.Height > 200) Height = iw.Height;

            Rectangle screen = Screen.PrimaryScreen!.WorkingArea;

            if (iw.X < screen.Width && iw.Y < screen.Height)
                Location = new Point(iw.X, iw.Y);

            Text = iw.Title;
        }

        // -------- SAVE INFO --------
        private void SaveFormInfo()
        {
            iw.Width = Width;
            iw.Height = Height;
            iw.X = Location.X;
            iw.Y = Location.Y;

            iw.Title = $"{Width} x {Height}";

            Text = iw.Title;

            Write(iw);
        }

        // Resize xong
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            SaveFormInfo();
        }

        // Di chuyển form
        private void Form1_LocationChanged(object? sender, EventArgs e)
        {
            SaveFormInfo();
        }

        // Đóng form
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveFormInfo();
        }
    }
}
