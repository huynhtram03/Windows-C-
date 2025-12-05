namespace Article10
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox tbDisplay;

        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;

        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnEqual;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ===================== DISPLAY =========================
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.tbDisplay.Location = new System.Drawing.Point(20, 20);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(360, 50);
            this.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDisplay.ReadOnly = true;
            this.tbDisplay.BackColor = System.Drawing.Color.White;

            // =============== BUTTON STYLE TEMPLATE =================
            int btnWidth = 80;
            int btnHeight = 60;

            // =============== ROW 1: 0 1 2 3 =======================
            this.btn0.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn0.Text = "0";
            this.btn0.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn0.Location = new System.Drawing.Point(20, 100);

            this.btn1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn1.Text = "1";
            this.btn1.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn1.Location = new System.Drawing.Point(110, 100);

            this.btn2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn2.Text = "2";
            this.btn2.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn2.Location = new System.Drawing.Point(200, 100);

            this.btn3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btn3.Text = "3";
            this.btn3.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btn3.Location = new System.Drawing.Point(290, 100);

            // =============== ROW 2: +  *  .  = ====================
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPlus.Text = "+";
            this.btnPlus.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnPlus.Location = new System.Drawing.Point(20, 170);

            this.btnMul.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnMul.Text = "*";
            this.btnMul.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnMul.Location = new System.Drawing.Point(110, 170);

            this.btnDot.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnDot.Text = ".";
            this.btnDot.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnDot.Location = new System.Drawing.Point(200, 170);

            this.btnEqual.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEqual.Text = "=";
            this.btnEqual.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnEqual.Location = new System.Drawing.Point(290, 170);

            // ==================== FORM =======================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 260);
            this.Controls.Add(this.tbDisplay);

            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn3);

            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnEqual);

            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
