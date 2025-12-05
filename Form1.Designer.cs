namespace Article09
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label lbKQ;

        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;

        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.lbKQ = new System.Windows.Forms.Label();

            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();

            this.btLuu = new System.Windows.Forms.Button();
            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ======= LABELS =======
            this.lbX.Text = "Số x";
            this.lbX.Location = new System.Drawing.Point(20, 20);
            this.lbX.AutoSize = true;

            this.lbY.Text = "Số y";
            this.lbY.Location = new System.Drawing.Point(20, 55);
            this.lbY.AutoSize = true;

            this.lbKQ.Text = "Kết quả";
            this.lbKQ.Location = new System.Drawing.Point(20, 90);
            this.lbKQ.AutoSize = true;

            // ======= TEXTBOX =======
            this.tbSoX.Location = new System.Drawing.Point(80, 17);
            this.tbSoX.Width = 680;
            this.tbSoX.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.tbSoY.Location = new System.Drawing.Point(80, 52);
            this.tbSoY.Width = 680;
            this.tbSoY.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.tbKetQua.Location = new System.Drawing.Point(80, 90);
            this.tbKetQua.Size = new System.Drawing.Size(680, 260);
            this.tbKetQua.Multiline = true;
            this.tbKetQua.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // ======= BUTTONS =======
            this.btLuu.Text = "Lưu";
            this.btLuu.Location = new System.Drawing.Point(20, 370);
            this.btLuu.Size = new System.Drawing.Size(80, 30);

            this.btCong.Text = "Cộng";
            this.btCong.Location = new System.Drawing.Point(480, 370);
            this.btCong.Size = new System.Drawing.Size(80, 30);
            this.btCong.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            this.btNhan.Text = "Nhân";
            this.btNhan.Location = new System.Drawing.Point(570, 370);
            this.btNhan.Size = new System.Drawing.Size(80, 30);
            this.btNhan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            this.btThoat.Text = "Thoát";
            this.btThoat.Location = new System.Drawing.Point(660, 370);
            this.btThoat.Size = new System.Drawing.Size(80, 30);
            this.btThoat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            // ======= FORM =======
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbKQ);

            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.tbKetQua);

            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btThoat);

            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
