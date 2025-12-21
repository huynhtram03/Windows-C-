namespace WinFormsApp1.GUI
{
    partial class FrmSuaPhongBan
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;

        private void InitializeComponent()
        {
            txtTenPB = new TextBox();
            lblTenPB = new Label();
            btnLuu = new Button();
            btnThoat = new Button();
            SuspendLayout();
            // 
            // txtTenPB
            // 
            txtTenPB.Location = new Point(140, 22);
            txtTenPB.Name = "txtTenPB";
            txtTenPB.Size = new Size(200, 31);
            txtTenPB.TabIndex = 0;
            // 
            // lblTenPB
            // 
            lblTenPB.AutoSize = true;
            lblTenPB.Location = new Point(20, 25);
            lblTenPB.Name = "lblTenPB";
            lblTenPB.Size = new Size(133, 25);
            lblTenPB.TabIndex = 1;
            lblTenPB.Text = "Tên Phòng Ban:";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(50, 70);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 35);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(180, 70);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 35);
            btnThoat.TabIndex = 3;
            btnThoat.Text = "Thoát";
            btnThoat.Click += btnThoat_Click;
            // 
            // FrmSuaPhongBan
            // 
            ClientSize = new Size(380, 212);
            Controls.Add(txtTenPB);
            Controls.Add(lblTenPB);
            Controls.Add(btnLuu);
            Controls.Add(btnThoat);
            Name = "FrmSuaPhongBan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sửa Phòng Ban";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
