namespace Article19
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtMa;
        private TextBox txtTen;
        private PictureBox pbImage;
        private Button btFile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.txtMa = new TextBox();
            this.txtTen = new TextBox();
            this.pbImage = new PictureBox();
            this.btFile = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();

            // label1 - Mã nhân viên
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.Text = "Mã nhân viên";

            // txtMa
            this.txtMa.Location = new System.Drawing.Point(140, 22);
            this.txtMa.Size = new System.Drawing.Size(200, 27);

            // label2 - Tên nhân viên
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.Text = "Tên nhân viên";

            // txtTen
            this.txtTen.Location = new System.Drawing.Point(140, 67);
            this.txtTen.Size = new System.Drawing.Size(200, 27);

            // label3 - Ảnh 3x4
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 115);
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.Text = "Ảnh 3 x 4";

            // PictureBox
            this.pbImage.BorderStyle = BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(140, 115);
            this.pbImage.Size = new System.Drawing.Size(120, 160);
            this.pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

            // Button chọn ảnh
            this.btFile.Location = new System.Drawing.Point(280, 225);
            this.btFile.Size = new System.Drawing.Size(100, 30);
            this.btFile.Text = "Chọn ảnh...";
            this.btFile.Click += new EventHandler(this.btFile_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.ClientSize = new System.Drawing.Size(420, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.btFile);
            this.Name = "Form1";
            this.Text = "Quản lý nhân sự";

            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
