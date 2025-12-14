namespace Article21
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Khai báo các Label mới
        private System.Windows.Forms.Label labelMa;
        private System.Windows.Forms.Label labelTen;
        private System.Windows.Forms.Label labelTuoi;
        private System.Windows.Forms.Label labelNam; // Cho chữ 'Nam' bên cạnh checkbox

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBAge;
        private System.Windows.Forms.CheckBox ckGender;
        private System.Windows.Forms.Button btAddNew; // Thay thế bằng btThem để dễ hiểu
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvEmployee = new System.Windows.Forms.DataGridView();

            // Khởi tạo các Label mới
            this.labelMa = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelTuoi = new System.Windows.Forms.Label();
            this.labelNam = new System.Windows.Forms.Label();

            this.tBId = new System.Windows.Forms.TextBox();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBAge = new System.Windows.Forms.TextBox();
            this.ckGender = new System.Windows.Forms.CheckBox();

            // Đổi tên biến để khớp với button Thêm/Xóa/Thoát trong hình
            this.btAddNew = new System.Windows.Forms.Button(); // Sẽ đổi Text thành Thêm
            this.btDelete = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();

            // ================================
            // DataGridView (Vị trí và kích thước đã điều chỉnh)
            // ================================
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(1, 1);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(630, 280); // Tăng kích thước
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.MultiSelect = false;
            // Dùng CellClick thay cho RowEnter để đảm bảo khớp với code logic
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_RowEnter);

            // Cột (Giữ nguyên)
            this.dgvEmployee.Columns.Add("Id", "Mã nhân viên");
            this.dgvEmployee.Columns.Add("Name", "Tên nhân viên");
            this.dgvEmployee.Columns.Add("Age", "Tuổi");
            var colGender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            colGender.Name = "Gender";
            colGender.HeaderText = "Giới tính (Nam)";
            this.dgvEmployee.Columns.Add(colGender);
            // Có thể thêm thuộc tính Fill để các cột lấp đầy chiều rộng
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;


            // ================================
            // Labels (Bổ sung để khớp giao diện)
            // ================================
            int labelX = 15;
            int textX = 80;

            // Label Mã
            this.labelMa.Text = "Mã";
            this.labelMa.Location = new System.Drawing.Point(labelX, 300);
            this.labelMa.AutoSize = true;
            this.labelMa.Name = "labelMa";
            this.labelMa.TabIndex = 0; // Đặt chỉ mục bất kỳ

            // Label Tên
            this.labelTen.Text = "Tên";
            this.labelTen.Location = new System.Drawing.Point(labelX, 330);
            this.labelTen.AutoSize = true;
            this.labelTen.Name = "labelTen";

            // Label Tuổi
            this.labelTuoi.Text = "Tuổi";
            this.labelTuoi.Location = new System.Drawing.Point(labelX, 360);
            this.labelTuoi.AutoSize = true;
            this.labelTuoi.Name = "labelTuoi";

            // Label Nam (chữ 'Nam' bên cạnh CheckBox)
            this.labelNam.Text = "Nam";
            this.labelNam.Location = new System.Drawing.Point(labelX + 25, 390); // Đặt gần CheckBox
            this.labelNam.AutoSize = true;
            this.labelNam.Name = "labelNam";


            // ================================
            // TextBoxes (Đã điều chỉnh vị trí)
            // ================================
            // TextBox ID
            this.tBId.Location = new System.Drawing.Point(textX, 297);
            this.tBId.Name = "tBId";
            this.tBId.Size = new System.Drawing.Size(150, 22);

            // TextBox Name
            this.tBName.Location = new System.Drawing.Point(textX, 327);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(300, 22);

            // TextBox Age
            this.tBAge.Location = new System.Drawing.Point(textX, 357);
            this.tBAge.Name = "tBAge";
            this.tBAge.Size = new System.Drawing.Size(80, 22);

            // ================================
            // CheckBox Gender (Đã điều chỉnh vị trí)
            // ================================
            this.ckGender.Location = new System.Drawing.Point(textX, 387); // Cùng hàng với label 'Nam'
            this.ckGender.Width = 20;
            this.ckGender.Name = "ckGender";
            this.ckGender.Text = "Nam"; // Đặt Text cho Checkbox như trong hình
            this.ckGender.UseVisualStyleBackColor = true;


            // ================================
            // Buttons (Đã điều chỉnh vị trí về góc dưới phải)
            // ================================
            int buttonY = 410; // Vị trí Y cho tất cả các nút
            int buttonWidth = 80;
            int buttonHeight = 25;

            // Button Add (Thêm)
            this.btAddNew.Text = "Thêm"; // Đổi Text thành Thêm
            this.btAddNew.Location = new System.Drawing.Point(370, buttonY);
            this.btAddNew.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btAddNew.Click += new System.EventHandler(this.btAddNew_Click);

            // Button Delete (Xóa)
            this.btDelete.Text = "Xóa";
            this.btDelete.Location = new System.Drawing.Point(460, buttonY);
            this.btDelete.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);

            // Button Exit (Thoát)
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new System.Drawing.Point(550, buttonY);
            this.btnThoat.Size = new System.Drawing.Size(buttonWidth, buttonHeight);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);


            // ================================
            // Form
            // ================================
            this.ClientSize = new System.Drawing.Size(640, 450); // Điều chỉnh kích thước Form

            // Thêm các Label vào Controls
            this.Controls.Add(this.labelMa);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.labelTuoi);
            this.Controls.Add(this.labelNam); // Chỉ thêm label Nam nếu không muốn chữ 'Nam' là phần của CheckBox

            // Thêm các control khác
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.tBAge);
            this.Controls.Add(this.ckGender);
            this.Controls.Add(this.btAddNew);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btnThoat);

            this.Name = "Form1";
            this.Text = "Form1"; // Giống như trên hình
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}