namespace Quanly.GUI
{
    partial class OrderPage
    {
        private System.ComponentModel.IContainer components = null;

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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.lblCus = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblCart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();

            // --- TỔNG THỂ FORM (Tăng chiều ngang để lấp đầy không gian) ---
            this.ClientSize = new System.Drawing.Size(950, 500);
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245); // Màu nền xám nhẹ hiện đại

            // --- DANH SÁCH SẢN PHẨM (CỘT TRÁI - RỘNG HƠN) ---
            this.lblProd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProd.Location = new System.Drawing.Point(25, 20);
            this.lblProd.Text = "DANH SÁCH SẢN PHẨM";
            this.lblProd.AutoSize = true;

            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProducts.ColumnHeadersHeight = 35;
            this.dgvProducts.Location = new System.Drawing.Point(25, 55);
            this.dgvProducts.Size = new System.Drawing.Size(500, 350); // Mở rộng chiều rộng lấp đầy bên trái
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.btnAddToCart.BackColor = System.Drawing.Color.White;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddToCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddToCart.Location = new System.Drawing.Point(180, 420);
            this.btnAddToCart.Size = new System.Drawing.Size(200, 45);
            this.btnAddToCart.Text = "THÊM VÀO GIỎ >>";
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);

            // --- THÔNG TIN ĐƠN HÀNG (CỘT PHẢI) ---
            int rightX = 550; // Tọa độ cột phải

            this.lblCus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCus.Location = new System.Drawing.Point(rightX, 25);
            this.lblCus.Text = "Chọn khách hàng:";
            this.lblCus.AutoSize = true;

            this.cboCustomer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboCustomer.Location = new System.Drawing.Point(rightX, 55);
            this.cboCustomer.Size = new System.Drawing.Size(370, 28);
            this.cboCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAddr.Location = new System.Drawing.Point(rightX, 100);
            this.lblAddr.Text = "Địa chỉ giao hàng:";
            this.lblAddr.AutoSize = true;

            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAddress.Location = new System.Drawing.Point(rightX, 125);
            this.txtAddress.Size = new System.Drawing.Size(370, 27);

            this.lblCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCart.Location = new System.Drawing.Point(rightX, 175);
            this.lblCart.Text = "Chi tiết giỏ hàng:";
            this.lblCart.AutoSize = true;

            this.dgvCart.BackgroundColor = System.Drawing.Color.White;
            this.dgvCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCart.Location = new System.Drawing.Point(rightX, 205);
            this.dgvCart.Size = new System.Drawing.Size(370, 200);
            this.dgvCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCart.RowHeadersVisible = false;

            this.btnPlaceOrder.BackColor = System.Drawing.Color.Gold;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlaceOrder.Location = new System.Drawing.Point(rightX, 420);
            this.btnPlaceOrder.Size = new System.Drawing.Size(370, 50);
            this.btnPlaceOrder.Text = "XÁC NHẬN ĐẶT HÀNG";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);

            // --- CONFIG CUỐI ---
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.dgvProducts, this.dgvCart, this.cboCustomer, this.txtAddress,
                this.btnAddToCart, this.btnPlaceOrder, this.lblCus, this.lblAddr, this.lblProd, this.lblCart
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Đơn hàng Chuyên nghiệp";
            this.Load += new System.EventHandler(this.OrderPage_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label lblCus;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblCart;
    }
}