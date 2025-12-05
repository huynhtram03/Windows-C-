namespace Article07
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.TextBox tbYear;
        private System.Windows.Forms.Label lbPhone;
        private System.Windows.Forms.TextBox tbPhone;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lbYear = new System.Windows.Forms.Label();
            this.tbYear = new System.Windows.Forms.TextBox();
            this.lbPhone = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(12, 18);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(31, 15);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = "Year";
            // 
            // tbYear
            // 
            this.tbYear.Location = new System.Drawing.Point(110, 15);
            this.tbYear.Name = "tbYear";
            this.tbYear.Size = new System.Drawing.Size(120, 23);
            this.tbYear.TabIndex = 1;
            // Gán sự kiện KeyPress và Validating
            this.tbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbYear_KeyPress);
            this.tbYear.Validating += new System.ComponentModel.CancelEventHandler(this.tbYear_Validating);
            // 
            // lbPhone
            // 
            this.lbPhone.AutoSize = true;
            this.lbPhone.Location = new System.Drawing.Point(12, 52);
            this.lbPhone.Name = "lbPhone";
            this.lbPhone.Size = new System.Drawing.Size(89, 15);
            this.lbPhone.TabIndex = 2;
            this.lbPhone.Text = "Phone Number";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(110, 49);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(120, 23);
            this.tbPhone.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 95);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.lbPhone);
            this.Controls.Add(this.tbYear);
            this.Controls.Add(this.lbYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
