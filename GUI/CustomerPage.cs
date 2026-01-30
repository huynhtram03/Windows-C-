using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Linq;

namespace Quanly.GUI
{
    public partial class CustomerPage : Form
    {
        // Chuỗi kết nối - Đảm bảo tên Database 'sale' đã tồn tại
        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=sale;Integrated Security=True";
        SqlConnection sqlCon = null;
        string currentImgPath = "";
        string oldID = ""; // Lưu mã KH cũ để phục vụ việc sửa ID

        public CustomerPage()
        {
            InitializeComponent();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            // Thiết lập ComboBox nếu chưa có dữ liệu
            if (cboGender.Items.Count == 0)
            {
                cboGender.Items.AddRange(new string[] { "Nam", "Nữ" });
                cboGender.SelectedIndex = 0;
            }
            HienThiDanhSach();
        }

        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();
                // Lấy dữ liệu từ bảng customer
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT id, name, gender, birthday, image_path FROM customer", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvCustomer.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dgvCustomer.Rows.Add();
                    dgvCustomer.Rows[n].Cells["colID"].Value = row["id"];
                    dgvCustomer.Rows[n].Cells["colName"].Value = row["name"];
                    dgvCustomer.Rows[n].Cells["colGender"].Value = row["gender"];
                    dgvCustomer.Rows[n].Cells["colBirthday"].Value = Convert.ToDateTime(row["birthday"]).ToShortDateString();

                    string path = row["image_path"].ToString();
                    dgvCustomer.Rows[n].Cells["image_path"].Value = path;

                    // Hiển thị ảnh thumbnail vào DataGridView nếu có
                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                        {
                            dgvCustomer.Rows[n].Cells["colAvatar"].Value = Image.FromStream(fs);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nạp danh sách: " + ex.Message); }
        }

        private bool KiemTraTrungID(string id)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM customer WHERE id = @id", sqlCon);
            cmd.Parameters.AddWithValue("@id", id);
            return (int)cmd.ExecuteScalar() > 0;
        }

        // Chọn ảnh đại diện
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImgPath = ofd.FileName;
                    picAvatar.Image = Image.FromFile(currentImgPath);
                }
            }
        }

        // Chức năng Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("Vui lòng nhập Mã!"); return; }
            if (KiemTraTrungID(id)) { MessageBox.Show("Mã đã tồn tại!"); return; }

            try
            {
                MoKetNoi();
                string sql = "INSERT INTO customer (id, name, gender, birthday, image_path) VALUES (@id, @name, @gender, @birthday, @img)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@img", currentImgPath);

                cmd.ExecuteNonQuery();
                HienThiDanhSach();
                btnClear_Click(null, null);
                MessageBox.Show("Thêm khách hàng thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi thêm: " + ex.Message); }
        }

        // Chức năng Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newID = txtID.Text.Trim();
            if (string.IsNullOrEmpty(oldID)) return;

            try
            {
                MoKetNoi();
                if (newID != oldID && KiemTraTrungID(newID)) { MessageBox.Show("Mã mới đã bị trùng!"); return; }

                string sql = "UPDATE customer SET id=@newID, name=@name, gender=@gender, birthday=@birthday, image_path=@img WHERE id=@oldID";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@newID", newID);
                cmd.Parameters.AddWithValue("@oldID", oldID);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@img", currentImgPath);

                cmd.ExecuteNonQuery();
                HienThiDanhSach();
                oldID = newID;
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        // Chức năng Xóa
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            if (MessageBox.Show("Xóa khách hàng này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    MoKetNoi();
                    SqlCommand cmd = new SqlCommand("DELETE FROM customer WHERE id=@id", sqlCon);
                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
                    cmd.ExecuteNonQuery();
                    HienThiDanhSach();
                    btnClear_Click(null, null);
                }
                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
            }
        }

        // Reset ô nhập liệu
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear(); txtName.Clear();
            oldID = ""; currentImgPath = "";
            picAvatar.Image = null;
            dtpBirthday.Value = DateTime.Now;
            txtID.Focus();
        }

        // Click vào bảng để đổ dữ liệu lên Control
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                txtID.Text = row.Cells["colID"].Value.ToString();
                oldID = txtID.Text;
                txtName.Text = row.Cells["colName"].Value.ToString();
                cboGender.Text = row.Cells["colGender"].Value.ToString();
                dtpBirthday.Value = Convert.ToDateTime(row.Cells["colBirthday"].Value);

                currentImgPath = row.Cells["image_path"].Value?.ToString();
                if (!string.IsNullOrEmpty(currentImgPath) && File.Exists(currentImgPath))
                {
                    using (FileStream fs = new FileStream(currentImgPath, FileMode.Open, FileAccess.Read))
                    {
                        picAvatar.Image = Image.FromStream(fs);
                    }
                }
                else picAvatar.Image = null;
            }
        }
    }
}