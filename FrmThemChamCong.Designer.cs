namespace WinFormsApp1.GUI
{
    partial class FrmThemChamCong
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtMaNV;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgay;
        private TextBox txtGioVao;
        private TextBox txtGioRa;
        private Button BtnOK;
        private Button BtnCancel;

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
            this.txtMaNV = new TextBox();
            this.txtHoTen = new TextBox();
            this.dtpNgay = new DateTimePicker();
            this.txtGioVao = new TextBox();
            this.txtGioRa = new TextBox();
            this.BtnOK = new Button();
            this.BtnCancel = new Button();

            this.SuspendLayout();

            // txtMaNV
            this.txtMaNV.Location = new System.Drawing.Point(120, 20);
            this.txtMaNV.Size = new System.Drawing.Size(200, 23);
            this.txtMaNV.PlaceholderText = "Mã NV";

            // txtHoTen
            this.txtHoTen.Location = new System.Drawing.Point(120, 60);
            this.txtHoTen.Size = new System.Drawing.Size(200, 23);
            this.txtHoTen.PlaceholderText = "Họ Tên";

            // dtpNgay
            this.dtpNgay.Location = new System.Drawing.Point(120, 100);
            this.dtpNgay.Size = new System.Drawing.Size(200, 23);
            this.dtpNgay.Format = DateTimePickerFormat.Custom;
            this.dtpNgay.CustomFormat = "yyyy-MM-dd";

            // txtGioVao
            this.txtGioVao.Location = new System.Drawing.Point(120, 140);
            this.txtGioVao.Size = new System.Drawing.Size(200, 23);
            this.txtGioVao.PlaceholderText = "Giờ Vào (HH:mm)";

            // txtGioRa
            this.txtGioRa.Location = new System.Drawing.Point(120, 180);
            this.txtGioRa.Size = new System.Drawing.Size(200, 23);
            this.txtGioRa.PlaceholderText = "Giờ Ra (HH:mm)";

            // BtnOK
            this.BtnOK.Location = new System.Drawing.Point(50, 220);
            this.BtnOK.Size = new System.Drawing.Size(100, 30);
            this.BtnOK.Text = "OK";
            this.BtnOK.Click += new EventHandler(this.BtnOK_Click);

            // BtnCancel
            this.BtnCancel.Location = new System.Drawing.Point(170, 220);
            this.BtnCancel.Size = new System.Drawing.Size(100, 30);
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.Click += new EventHandler(this.BtnCancel_Click);

            // FrmThemChamCong
            this.ClientSize = new System.Drawing.Size(350, 280);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.dtpNgay);
            this.Controls.Add(this.txtGioVao);
            this.Controls.Add(this.txtGioRa);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Text = "Thêm chấm công";
            this.StartPosition = FormStartPosition.CenterParent;

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
