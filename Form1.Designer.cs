namespace Article12
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cb_Faculty;
        private TextBox tbDisplay;
        private Button btOK;

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
            this.cb_Faculty = new System.Windows.Forms.ComboBox();
            this.tbDisplay = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_Faculty
            // 
            this.cb_Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Faculty.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_Faculty.FormattingEnabled = true;
            this.cb_Faculty.Items.AddRange(new object[] {
            "Khoa CNTT",
            "Khoa Kinh Tế",
            "Khoa Ngoại Ngữ",
            "Khoa Toán",
            "Khoa Điện – Điện Tử"});
            this.cb_Faculty.Location = new System.Drawing.Point(40, 40);
            this.cb_Faculty.Name = "cb_Faculty";
            this.cb_Faculty.Size = new System.Drawing.Size(250, 29);
            this.cb_Faculty.TabIndex = 0;
            this.cb_Faculty.SelectedIndexChanged += new System.EventHandler(this.cb_Faculty_SelectedIndexChanged);
            // 
            // tbDisplay
            // 
            this.tbDisplay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbDisplay.Location = new System.Drawing.Point(40, 100);
            this.tbDisplay.Name = "tbDisplay";
            this.tbDisplay.Size = new System.Drawing.Size(250, 29);
            this.tbDisplay.TabIndex = 1;
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btOK.Location = new System.Drawing.Point(40, 150);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(250, 40);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 230);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbDisplay);
            this.Controls.Add(this.cb_Faculty);
            this.Name = "Form1";
            this.Text = "Chọn Khoa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
