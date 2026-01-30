using System.Drawing;
using System.Windows.Forms;

namespace Quanly.GUI
{
    partial class ProductPage
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboMaterial = new System.Windows.Forms.ComboBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblL_ID = new System.Windows.Forms.Label();
            this.lblL_Name = new System.Windows.Forms.Label();
            this.lblL_Material = new System.Windows.Forms.Label();
            this.lblL_Weight = new System.Windows.Forms.Label();
            this.lblL_Price = new System.Windows.Forms.Label();
            this.lblL_Stock = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.btnChooseImg = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            // Khởi tạo cột Grid
            this.colImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Mới
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn(); // Mới

            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();

            // Cấu hình panelTop & Header
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(45, 52, 54);
            this.panelTop.Controls.Add(this.lblHeader);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(1000, 50);
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Text = "QUẢN LÝ SẢN PHẨM TRANG SỨC";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // grpDetail (Bố cục thông tin nhập liệu)
            this.grpDetail.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnChooseImg, this.picProduct, this.txtStock, this.lblL_Stock,
                this.txtPrice, this.lblL_Price, this.txtWeight, this.lblL_Weight,
                this.cboMaterial, this.lblL_Material, this.txtName, this.lblL_Name,
                this.txtID, this.lblL_ID
            });
            this.grpDetail.Location = new System.Drawing.Point(15, 100);
            this.grpDetail.Size = new System.Drawing.Size(780, 195);
            this.grpDetail.Text = "Thông tin sản phẩm";

            // Vị trí các Controls (Mã SP, Tên, Chất liệu...)
            this.lblL_ID.Text = "Mã SP:"; this.lblL_ID.Location = new System.Drawing.Point(15, 35);
            this.txtID.Location = new System.Drawing.Point(90, 32); this.txtID.Size = new System.Drawing.Size(120, 25);

            this.lblL_Name.Text = "Tên SP:"; this.lblL_Name.Location = new System.Drawing.Point(15, 70);
            this.txtName.Location = new System.Drawing.Point(90, 67); this.txtName.Size = new System.Drawing.Size(350, 25);

            this.lblL_Material.Text = "Chất liệu:"; this.lblL_Material.Location = new System.Drawing.Point(15, 105);
            this.cboMaterial.Location = new System.Drawing.Point(90, 102); this.cboMaterial.Size = new System.Drawing.Size(140, 25);

            this.lblL_Weight.Text = "Trọng lượng:"; this.lblL_Weight.Location = new System.Drawing.Point(240, 105);
            this.txtWeight.Location = new System.Drawing.Point(320, 102); this.txtWeight.Size = new System.Drawing.Size(120, 25);

            this.lblL_Price.Text = "Giá bán:"; this.lblL_Price.Location = new System.Drawing.Point(15, 140);
            this.txtPrice.Location = new System.Drawing.Point(90, 137); this.txtPrice.Size = new System.Drawing.Size(140, 25);

            this.lblL_Stock.Text = "Số lượng:"; this.lblL_Stock.Location = new System.Drawing.Point(240, 140);
            this.txtStock.Location = new System.Drawing.Point(320, 137); this.txtStock.Size = new System.Drawing.Size(120, 25);

            this.picProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picProduct.Location = new System.Drawing.Point(460, 25);
            this.picProduct.Size = new System.Drawing.Size(300, 125);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChooseImg.Location = new System.Drawing.Point(460, 155);
            this.btnChooseImg.Size = new System.Drawing.Size(300, 30);
            this.btnChooseImg.Text = "📷 Chọn hình ảnh sản phẩm";

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(810, 110);
            this.btnAdd.Text = "Thêm sp";
            this.btnAdd.Size = new System.Drawing.Size(165, 40);
            this.btnAdd.BackColor = Color.FromArgb(46, 204, 113);
            this.btnUpdate.Location = new System.Drawing.Point(810, 155);
            this.btnUpdate.Text = "Sửa sản phẩm";

            this.btnUpdate.Size = new System.Drawing.Size(165, 40); this.btnUpdate.BackColor = Color.FromArgb(52, 152, 219);
            this.btnDelete.Location = new System.Drawing.Point(810, 200);
            this.btnDelete.Text = "Xoá sản phẩm";

            this.btnDelete.Size = new System.Drawing.Size(165, 40); this.btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            this.btnRefresh.Location = new System.Drawing.Point(810, 245);
            this.btnRefresh.Text = "Làm mới";

            this.btnRefresh.Size = new System.Drawing.Size(165, 40); this.btnRefresh.BackColor = Color.DarkGray;

            // --- DataGridView ---
            this.dgvProducts.AutoGenerateColumns = false; // Ngăn tự sinh cột
            this.dgvProducts.Location = new System.Drawing.Point(15, 310);
            this.dgvProducts.Size = new System.Drawing.Size(960, 330);
            this.dgvProducts.RowTemplate.Height = 80;
            this.dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Cấu hình từng cột chi tiết
            this.colImage.HeaderText = "Hình Ảnh"; this.colImage.Name = "colImage"; this.colImage.ImageLayout = DataGridViewImageCellLayout.Zoom; this.colImage.Width = 100;
            this.colID.DataPropertyName = "id"; this.colID.HeaderText = "Mã SP"; this.colID.Name = "id";
            this.colName.DataPropertyName = "name"; this.colName.HeaderText = "Tên Sản Phẩm"; this.colName.Name = "name";
            this.colMaterial.DataPropertyName = "material"; this.colMaterial.HeaderText = "Chất Liệu"; this.colMaterial.Name = "material";
            this.colWeight.DataPropertyName = "weight"; this.colWeight.Name = "weight"; this.colWeight.Visible = false; // Cột ẩn để lưu giá trị weight
            this.colPrice.DataPropertyName = "price"; this.colPrice.HeaderText = "Giá Bán"; this.colPrice.Name = "price";
            this.colStock.DataPropertyName = "stock"; this.colStock.HeaderText = "Số Lượng"; this.colStock.Name = "stock";
            this.colTotal.DataPropertyName = "total_value"; this.colTotal.HeaderText = "Thành Tiền"; this.colTotal.Name = "total_value";
            this.colImagePath.DataPropertyName = "image_path"; this.colImagePath.Name = "image_path"; this.colImagePath.Visible = false; // Cột ẩn để lưu đường dẫn

            this.dgvProducts.Columns.AddRange(new DataGridViewColumn[] {
                this.colImage, this.colID, this.colName, this.colMaterial,
                this.colPrice, this.colStock, this.colTotal, this.colWeight, this.colImagePath
            });

            // Form Settings
            this.ClientSize = new System.Drawing.Size(1000, 660);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvProducts, this.btnRefresh, this.btnDelete, this.btnUpdate, this.btnAdd, this.grpDetail, this.txtSearch, this.panelTop });
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtSearch, txtID, txtName, txtWeight, txtPrice, txtStock;
        private System.Windows.Forms.ComboBox cboMaterial;
        private System.Windows.Forms.Label lblL_ID, lblL_Name, lblL_Material, lblL_Weight, lblL_Price, lblL_Stock;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnChooseImg, btnAdd, btnUpdate, btnDelete, btnRefresh;
        private System.Windows.Forms.DataGridViewImageColumn colImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID, colName, colMaterial, colWeight, colPrice, colStock, colTotal, colImagePath;
    }
}