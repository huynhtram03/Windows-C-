namespace Article23
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btLeft = new System.Windows.Forms.Button();
            this.btRight = new System.Windows.Forms.Button();
            this.btFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLeft
            // 
            this.btLeft.Location = new System.Drawing.Point(180, 220);
            this.btLeft.Name = "btLeft";
            this.btLeft.Size = new System.Drawing.Size(50, 40);
            this.btLeft.Text = "<-";
            this.btLeft.Click += new System.EventHandler(this.btLeft_Click);
            // 
            // btRight
            // 
            this.btRight.Location = new System.Drawing.Point(236, 220);
            this.btRight.Name = "btRight";
            this.btRight.Size = new System.Drawing.Size(50, 40);
            this.btRight.Text = "->";
            this.btRight.Click += new System.EventHandler(this.btRight_Click);
            // 
            // btFile
            // 
            this.btFile.Location = new System.Drawing.Point(320, 220);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(100, 40);
            this.btFile.Text = "File...";
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.btFile);
            this.Controls.Add(this.btRight);
            this.Controls.Add(this.btLeft);
            this.Name = "Form1";
            this.Text = "Simple Game";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btLeft;
        private System.Windows.Forms.Button btRight;
        private System.Windows.Forms.Button btFile;
    }
}