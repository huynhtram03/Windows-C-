namespace Article11
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtDisplay;

        private Button[] buttons;

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
            this.txtDisplay = new TextBox();
            this.SuspendLayout();

            // ========== DISPLAY ==========
            this.txtDisplay.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.txtDisplay.Location = new System.Drawing.Point(10, 10);
            this.txtDisplay.Size = new System.Drawing.Size(360, 55);
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.TextAlign = HorizontalAlignment.Right;

            // ======== Tạo 25 Button ========
            string[] labels =
            {
                "MC","MR","MS","M+","M-",
                "←","CE","C","±","√",
                "7","8","9","/","%",
                "4","5","6","*","1/x",
                "1","2","3","-","=",
                "0",".","+"
            };

            buttons = new Button[labels.Length];

            int x = 10, y = 80;
            int w = 65, h = 45;
            int col = 0;

            for (int i = 0; i < labels.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = labels[i];
                buttons[i].Font = new System.Drawing.Font("Segoe UI", 12F);
                buttons[i].Size = new System.Drawing.Size(w, h);
                buttons[i].Location = new System.Drawing.Point(x + col * 70, y);
                buttons[i].Click += Button_Click;

                this.Controls.Add(buttons[i]);

                col++;
                if (col == 5)
                {
                    col = 0;
                    y += 50;
                }
            }

            // ========= FORM =========
            this.ClientSize = new System.Drawing.Size(370, 370);
            this.Controls.Add(this.txtDisplay);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "My Calculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
