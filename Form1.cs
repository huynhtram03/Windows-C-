using System;
using System.Windows.Forms;

namespace Article19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btFile_Click(object sender, EventArgs e)
        {
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open Image";
            dlg.Filter = "JPEG files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pbImage.ImageLocation = dlg.FileName;
            }
        }
    }
}
