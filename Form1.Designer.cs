namespace Article16
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdMale;
        private System.Windows.Forms.RadioButton rdFemale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFaculty;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ListBox lbStatus;

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
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdMale = new System.Windows.Forms.RadioButton();
            this.rdFemale = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFaculty = new System.Windows.Forms.ComboBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 30);
            this.label1.Text = "Họ và tên:";

            // tbName
            this.tbName.Location = new System.Drawing.Point(150, 27);
            this.tbName.Size = new System.Drawing.Size(220, 27);

            // label2
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 80);
            this.label2.Text = "Giới tính:";

            // rdMale
            this.rdMale.AutoSize = true;
            this.rdMale.Location = new System.Drawing.Point(150, 78);
            this.rdMale.Text = "Nam";

            // rdFemale
            this.rdFemale.AutoSize = true;
            this.rdFemale.Location = new System.Drawing.Point(230, 78);
            this.rdFemale.Text = "Nữ";

            // label3
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 130);
            this.label3.Text = "Ngày sinh:";

            // dtpBirth
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(150, 125);
            this.dtpBirth.Size = new System.Drawing.Size(220, 27);

            // label4
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 180);
            this.label4.Text = "Khoa:";

            // cbFaculty
            this.cbFaculty.Location = new System.Drawing.Point(150, 175);
            this.cbFaculty.Size = new System.Drawing.Size(220, 28);

            // btAdd
            this.btAdd.Location = new System.Drawing.Point(40, 230);
            this.btAdd.Size = new System.Drawing.Size(120, 40);
            this.btAdd.Text = "Thêm";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);

            // btExit
            this.btExit.Location = new System.Drawing.Point(180, 230);
            this.btExit.Size = new System.Drawing.Size(120, 40);
            this.btExit.Text = "Thoát";
            this.btExit.Click += new System.EventHandler(this.btExit_Click);

            // lbStatus
            this.lbStatus.Location = new System.Drawing.Point(40, 290);
            this.lbStatus.Size = new System.Drawing.Size(360, 150);

            // Form1
            this.ClientSize = new System.Drawing.Size(450, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdMale);
            this.Controls.Add(this.rdFemale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbFaculty);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbStatus);
            this.Text = "Thông tin sinh viên";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
