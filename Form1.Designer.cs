namespace Article26
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
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500); // Kích thước Form rộng hơn để dễ thấy
            this.Name = "Form1";
            this.Text = "Game Trứng Rơi";
            this.Load += new System.EventHandler(this.Form1_Load); // Gán sự kiện Load cho Form
            this.ResumeLayout(false);
        }

        #endregion
    }
}