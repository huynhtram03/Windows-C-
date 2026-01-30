using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Quanly.GUI
{
    public partial class ProductPage : Form
    {
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=sale;Integrated Security=True";
        private string currentImagePath = "";
        private string originalID = "";

        public ProductPage()
        {
            InitializeComponent();
            SetupEvents();
        }

        private void SetupEvents()
        {
            // Thiết lập ComboBox
            cboMaterial.Items.Clear();
            cboMaterial.Items.AddRange(new string[] { "Vàng 18K", "Vàng 24K", "Bạch Kim", "Bạc S925", "Kim Cương" });
            cboMaterial.SelectedIndex = 0;

            // Load dữ liệu khi mở form
            this.Load += (s, e) => LoadProductData();
            
            // Xử lý nạp ảnh vào Grid (Fix lỗi dấu X đỏ)
            dgvProducts.DataBindingComplete += dgvProducts_DataBindingComplete;
            
            // Sự kiện các nút bấm
            dgvProducts.CellClick += dgvProducts_CellClick;
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += (s, e) => ClearInput();
            
            // Tìm kiếm
            txtSearch.TextChanged += txtSearch_TextChanged;
            btnChooseImg.Click += btnChooseImg_Click;
        }

        public void LoadProductData()
        {
            string query = @"SELECT id, name, material, weight, price, stock, image_path, (price * stock) AS total_value 
                             FROM product ORDER BY id DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProducts.DataSource = dt;
                    FormatGrid();
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message); }
        }

        private void dgvProducts_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                try
                {
                    string path = row.Cells["image_path"].Value?.ToString();
                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        {
                            row.Cells["colImage"].Value = Image.FromStream(fs);
                        }
                    }
                    else { row.Cells["colImage"].Value = null; }
                }
                catch { row.Cells["colImage"].Value = null; }
            }
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProducts.Rows[e.RowIndex];
                originalID = row.Cells["id"].Value?.ToString();
                txtID.Text = originalID;
                txtName.Text = row.Cells["name"].Value?.ToString();
                cboMaterial.Text = row.Cells["material"].Value?.ToString();
                txtWeight.Text = row.Cells["weight"].Value?.ToString();
                txtPrice.Text = row.Cells["price"].Value?.ToString();
                txtStock.Text = row.Cells["stock"].Value?.ToString();
                currentImagePath = row.Cells["image_path"].Value?.ToString();
                ShowImage(currentImagePath);
            }
        }

        private void ShowImage(string path)
        {
            try {
                if (!string.IsNullOrEmpty(path) && File.Exists(path)) {
                    using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        picProduct.Image = Image.FromStream(fs);
                } else picProduct.Image = null;
            } catch { picProduct.Image = null; }
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog()) {
                ofd.Filter = "Images|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK) {
                    currentImagePath = ofd.FileName;
                    ShowImage(currentImagePath);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) => ExecuteQuery("INSERT INTO product VALUES (@id, @name, @mat, @weight, @price, @stock, @img)", "Thêm mới thành công!");

        private void btnUpdate_Click(object sender, EventArgs e) => ExecuteQuery("UPDATE product SET id=@id, name=@name, material=@mat, weight=@weight, price=@price, stock=@stock, image_path=@img WHERE id=@oldid", "Cập nhật thành công!", true);

        private void btnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("Xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                ExecuteQuery("DELETE FROM product WHERE id=@id", "Đã xóa sản phẩm!");
        }

        private void ExecuteQuery(string query, string msg, bool isUpdate = false)
        {
            try {
                using (SqlConnection conn = new SqlConnection(connectionString)) {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@mat", cboMaterial.Text);
                    cmd.Parameters.AddWithValue("@weight", txtWeight.Text.Trim());
                    cmd.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text));
                    cmd.Parameters.AddWithValue("@stock", int.Parse(txtStock.Text));
                    cmd.Parameters.AddWithValue("@img", currentImagePath);
                    if (isUpdate) cmd.Parameters.AddWithValue("@oldid", originalID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(msg);
                    LoadProductData();
                    ClearInput();
                }
            } catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgvProducts.DataSource is DataTable dt)
                dt.DefaultView.RowFilter = string.Format("name LIKE '%{0}%' OR id LIKE '%{0}%'", txtSearch.Text);
        }

        private void FormatGrid()
        {
            if (dgvProducts.Columns["price"] != null) dgvProducts.Columns["price"].DefaultCellStyle.Format = "N0";
            if (dgvProducts.Columns["total_value"] != null) dgvProducts.Columns["total_value"].DefaultCellStyle.Format = "N0";
        }

        private void ClearInput() {
            txtID.Clear(); txtName.Clear(); txtWeight.Clear(); txtPrice.Clear(); txtStock.Clear();
            picProduct.Image = null; currentImagePath = ""; originalID = "";
        }
    }
}