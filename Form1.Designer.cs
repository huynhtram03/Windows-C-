namespace WinFormsApp1.GUI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Timer snowTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.snowTimer = new System.Windows.Forms.Timer(this.components);

            this.panelCard.SuspendLayout();
            this.SuspendLayout();

            // ========= PANEL CARD =========
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.Location = new System.Drawing.Point(120, 100);
            this.panelCard.Size = new System.Drawing.Size(360, 360);

            this.panelCard.Controls.Add(this.lblTitle);
            this.panelCard.Controls.Add(this.lblUser);
            this.panelCard.Controls.Add(this.txtUser);
            this.panelCard.Controls.Add(this.lblPass);
            this.panelCard.Controls.Add(this.txtPass);
            this.panelCard.Controls.Add(this.btnLogin);

            // ========= TITLE =========
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(30, 90, 180);
            this.lblTitle.Location = new System.Drawing.Point(110, 30);
            this.lblTitle.Text = "LOGIN";

            // ========= USER =========
            this.lblUser.Text = "Username";
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUser.Location = new System.Drawing.Point(40, 90);

            this.txtUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtUser.Location = new System.Drawing.Point(40, 115);
            this.txtUser.Size = new System.Drawing.Size(280, 30);

            // ========= PASS =========
            this.lblPass.Text = "Password";
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPass.Location = new System.Drawing.Point(40, 165);

            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPass.Location = new System.Drawing.Point(40, 190);
            this.txtPass.PasswordChar = '●';
            this.txtPass.Size = new System.Drawing.Size(280, 30);

            // ========= BUTTON =========
            this.btnLogin.Text = "SIGN IN";
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Location = new System.Drawing.Point(40, 255);
            this.btnLogin.Size = new System.Drawing.Size(280, 45);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // ========= SNOW TIMER =========
            this.snowTimer.Interval = 40;
            this.snowTimer.Tick += new System.EventHandler(this.snowTimer_Tick);

            // ========= FORM =========
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(15, 32, 65);
            this.ClientSize = new System.Drawing.Size(600, 550);
            this.Controls.Add(this.panelCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleBuffered = true;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);

            this.panelCard.ResumeLayout(false);
            this.panelCard.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
