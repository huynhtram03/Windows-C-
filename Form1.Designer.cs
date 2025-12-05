namespace Article08
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblSoX;
        private System.Windows.Forms.Label lblSoY;
        private System.Windows.Forms.Label lblKetQua;

        private System.Windows.Forms.TextBox tbSoX;
        private System.Windows.Forms.TextBox tbSoY;
        private System.Windows.Forms.TextBox tbKetQua;

        private System.Windows.Forms.Button btCong;
        private System.Windows.Forms.Button btNhan;
        private System.Windows.Forms.Button btThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblSoX = new System.Windows.Forms.Label();
            this.lblSoY = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();

            this.tbSoX = new System.Windows.Forms.TextBox();
            this.tbSoY = new System.Windows.Forms.TextBox();
            this.tbKetQua = new System.Windows.Forms.TextBox();

            this.btCong = new System.Windows.Forms.Button();
            this.btNhan = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // LABEL Số X
            this.lblSoX.AutoSize = true;
            this.lblSoX.Location = new System.Drawing.Point(20, 20);
            this.lblSoX.Name = "lblSoX";
            this.lblSoX.Size = new System.Drawing.Size(32, 20);
            this.lblSoX.Text = "Số x";

            // TEXTBOX Số X
            this.tbSoX.Location = new System.Drawing.Point(80, 17);
            this.tbSoX.Name = "tbSoX";
            this.tbSoX.Size = new System.Drawing.Size(180, 27);

            // LABEL Số Y
            this.lblSoY.AutoSize = true;
            this.lblSoY.Location = new System.Drawing.Point(20, 60);
            this.lblSoY.Name = "lblSoY";
            this.lblSoY.Size = new System.Drawing.Size(32, 20);
            this.lblSoY.Text = "Số y";

            // TEXTBOX Số Y
            this.tbSoY.Location = new System.Drawing.Point(80, 57);
            this.tbSoY.Name = "tbSoY";
            this.tbSoY.Size = new System.Drawing.Size(180, 27);

            // LABEL Kết quả
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(20, 100);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(58, 20);
            this.lblKetQua.Text = "Kết quả";

            // TEXTBOX Kết quả
            this.tbKetQua.Location = new System.Drawing.Point(80, 97);
            this.tbKetQua.Name = "tbKetQua";
            this.tbKetQua.ReadOnly = true;
            this.tbKetQua.Size = new System.Drawing.Size(180, 27);

            // BUTTON Cộng
            this.btCong.Location = new System.Drawing.Point(40, 140);
            this.btCong.Name = "btCong";
            this.btCong.Size = new System.Drawing.Size(60, 30);
            this.btCong.Text = "Cộng";
            this.btCong.UseVisualStyleBackColor = true;
            this.btCong.Click += new System.EventHandler(this.btCong_Click);

            // BUTTON Nhân
            this.btNhan.Location = new System.Drawing.Point(120, 140);
            this.btNhan.Name = "btNhan";
            this.btNhan.Size = new System.Drawing.Size(60, 30);
            this.btNhan.Text = "Nhân";
            this.btNhan.UseVisualStyleBackColor = true;
            this.btNhan.Click += new System.EventHandler(this.btNhan_Click);

            // BUTTON Thoát
            this.btThoat.Location = new System.Drawing.Point(200, 140);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(60, 30);
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);

            this.Controls.Add(this.lblSoX);
            this.Controls.Add(this.tbSoX);
            this.Controls.Add(this.lblSoY);
            this.Controls.Add(this.tbSoY);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.tbKetQua);
            this.Controls.Add(this.btCong);
            this.Controls.Add(this.btNhan);
            this.Controls.Add(this.btThoat);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caculator";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
