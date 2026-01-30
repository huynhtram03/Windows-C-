using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quanly.GUI
{
    public partial class OrderPage : Form
    {
        // Chuỗi kết nối - Hãy đảm bảo Catalog khớp với tên DB bạn đã tạo
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=sale;Integrated Security=True";
        private DataTable cartTable = new DataTable();

        public OrderPage()
        {
            InitializeComponent();
            SetupCart();
        }

        private void OrderPage_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCustomers();
        }

        // Khởi tạo cấu trúc giỏ hàng ảo
        private void SetupCart()
        {
            if (cartTable.Columns.Count == 0)
            {
                cartTable.Columns.Add("ProductID", typeof(string));
                cartTable.Columns.Add("ProductName", typeof(string));
                cartTable.Columns.Add("Quantity", typeof(int));
                cartTable.Columns.Add("UnitPrice", typeof(decimal));
                cartTable.Columns.Add("Total", typeof(decimal), "Quantity * UnitPrice");
            }
            dgvCart.DataSource = cartTable;

            // Định dạng hiển thị tiền tệ cho cột Total và UnitPrice
            dgvCart.Columns["UnitPrice"].DefaultCellStyle.Format = "N0";
            dgvCart.Columns["Total"].DefaultCellStyle.Format = "N0";
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT id, name, material, price, stock FROM product";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProducts.DataSource = dt;
                    dgvProducts.Columns["price"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải sản phẩm: " + ex.Message); }
        }

        private void LoadCustomers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT id, name FROM customer";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    cboCustomer.DataSource = dt;
                    cboCustomer.DisplayMember = "name";
                    cboCustomer.ValueMember = "id";
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi tải khách hàng: " + ex.Message); }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow != null)
            {
                var row = dgvProducts.CurrentRow;
                string pId = row.Cells["id"].Value.ToString();

                // Kiểm tra trùng lặp trong giỏ hàng
                DataRow[] found = cartTable.Select($"ProductID = '{pId}'");
                if (found.Length > 0)
                {
                    found[0]["Quantity"] = (int)found[0]["Quantity"] + 1;
                }
                else
                {
                    cartTable.Rows.Add(pId, row.Cells["name"].Value, 1, row.Cells["price"].Value);
                }
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cartTable.Rows.Count == 0) { MessageBox.Show("Giỏ hàng đang trống!"); return; }
            if (string.IsNullOrEmpty(txtAddress.Text)) { MessageBox.Show("Vui lòng nhập địa chỉ giao hàng!"); return; }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    // 1. Tính tổng tiền
                    decimal total = Convert.ToDecimal(cartTable.Compute("Sum(Total)", ""));

                    // 2. Lưu Đơn hàng
                    string sqlOrder = @"INSERT INTO orders (customer_id, total_amount, payment_status, order_status, shipping_address) 
                                       OUTPUT INSERTED.order_id VALUES (@cId, @total, N'Chờ thanh toán', N'Mới', @addr)";
                    SqlCommand cmdOrder = new SqlCommand(sqlOrder, conn, trans);
                    cmdOrder.Parameters.AddWithValue("@cId", cboCustomer.SelectedValue);
                    cmdOrder.Parameters.AddWithValue("@total", total);
                    cmdOrder.Parameters.AddWithValue("@addr", txtAddress.Text);
                    int orderId = (int)cmdOrder.ExecuteScalar();

                    // 3. Lưu Chi tiết & Trừ tồn kho
                    foreach (DataRow r in cartTable.Rows)
                    {
                        string sqlDetail = "INSERT INTO order_details (order_id, product_id, quantity, unit_price) VALUES (@oId, @pId, @q, @u)";
                        SqlCommand cmdDetail = new SqlCommand(sqlDetail, conn, trans);
                        cmdDetail.Parameters.AddWithValue("@oId", orderId);
                        cmdDetail.Parameters.AddWithValue("@pId", r["ProductID"]);
                        cmdDetail.Parameters.AddWithValue("@q", r["Quantity"]);
                        cmdDetail.Parameters.AddWithValue("@u", r["UnitPrice"]);
                        cmdDetail.ExecuteNonQuery();

                        // Cập nhật kho
                        string sqlUpdateStock = "UPDATE product SET stock = stock - @q WHERE id = @pId";
                        SqlCommand cmdStock = new SqlCommand(sqlUpdateStock, conn, trans);
                        cmdStock.Parameters.AddWithValue("@q", r["Quantity"]);
                        cmdStock.Parameters.AddWithValue("@pId", r["ProductID"]);
                        cmdStock.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show($"Đặt hàng thành công! Mã đơn: {orderId}", "Thông báo");
                    cartTable.Rows.Clear();
                    txtAddress.Clear();
                    LoadProducts(); // Refresh lại kho
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message);
                }
            }
        }
    }
}