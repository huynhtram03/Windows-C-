//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using System.Data.SqlClient;

//namespace Article01
//{
//    public partial class Form1 : Form
//    {
//        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=sale;Integrated Security=True";
//        SqlConnection sqlCon = null;

//        public Form1()
//        {
//            InitializeComponent();
//        }

//        private void Form1_Load(object sender, EventArgs e)
//        {
//            dgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
//            dgvCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
//            dgvCustomer.ReadOnly = true;

//            // Thiết lập giá trị mặc định cho ComboBox Giới tính nếu chưa có trong Designer
//            if (cboGender.Items.Count == 0)
//            {
//                cboGender.Items.Add("Nam");
//                cboGender.Items.Add("Nữ");
//                cboGender.SelectedIndex = 0;
//            }

//            HienThiDanhSach();
//        }

//        private void MoKetNoi()
//        {
//            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
//            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
//        }

//        private void HienThiDanhSach()
//        {
//            try
//            {
//                MoKetNoi();
//                // Truy vấn lấy đầy đủ 4 cột
//                string query = "SELECT id as 'Mã KH', name as 'Tên KH', gender as 'Giới tính', birthday as 'Ngày sinh' FROM customer";
//                SqlDataAdapter adapter = new SqlDataAdapter(query, sqlCon);
//                DataTable dt = new DataTable();
//                adapter.Fill(dt);
//                dgvCustomer.DataSource = dt;
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
//            }
//        }

//        // 1. CHỨC NĂNG THÊM
//        private void btnAdd_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text))
//            {
//                MessageBox.Show("Vui lòng nhập đầy đủ ID và Tên!");
//                return;
//            }

//            try
//            {
//                MoKetNoi();
//                string sql = "INSERT INTO customer (id, name, gender, birthday) VALUES (@id, @name, @gender, @birthday)";
//                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
//                {
//                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
//                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
//                    cmd.Parameters.AddWithValue("@gender", cboGender.Text);
//                    cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value); // Lấy giá trị từ DateTimePicker

//                    cmd.ExecuteNonQuery();
//                    HienThiDanhSach();
//                    MessageBox.Show("Thêm mới thành công!");
//                    btnClear_Click(null, null);
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi thêm mới: " + ex.Message);
//            }
//        }

//        // 2. CHỨC NĂNG SỬA
//        private void btnEdit_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(txtID.Text)) return;

//            try
//            {
//                MoKetNoi();
//                string sql = "UPDATE customer SET name = @name, gender = @gender, birthday = @birthday WHERE id = @id";
//                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
//                {
//                    cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
//                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
//                    cmd.Parameters.AddWithValue("@gender", cboGender.Text);
//                    cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value);

//                    int result = cmd.ExecuteNonQuery();
//                    if (result > 0)
//                    {
//                        HienThiDanhSach();
//                        MessageBox.Show("Cập nhật thành công!");
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                MessageBox.Show("Lỗi sửa: " + ex.Message);
//            }
//        }

//        // 3. CHỨC NĂNG XÓA
//        private void btnDelete_Click(object sender, EventArgs e)
//        {
//            if (string.IsNullOrWhiteSpace(txtID.Text)) return;

//            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
//            {
//                try
//                {
//                    MoKetNoi();
//                    string sql = "DELETE FROM customer WHERE id = @id";
//                    using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
//                    {
//                        cmd.Parameters.AddWithValue("@id", txtID.Text.Trim());
//                        cmd.ExecuteNonQuery();
//                        HienThiDanhSach();
//                        btnClear_Click(null, null);
//                        MessageBox.Show("Xóa thành công!");
//                    }
//                }
//                catch (Exception ex) { MessageBox.Show("Lỗi xóa: " + ex.Message); }
//            }
//        }

//        private void btnClear_Click(object sender, EventArgs e)
//        {
//            txtID.Clear();
//            txtName.Clear();
//            cboGender.SelectedIndex = 0;
//            dtpBirthday.Value = DateTime.Now;
//            txtID.ReadOnly = false;
//            txtID.Focus();
//        }

//        // SỰ KIỆN CLICK BẢNG: Đổ dữ liệu ngược lại các ô nhập
//        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//            if (e.RowIndex >= 0)
//            {
//                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
//                txtID.Text = row.Cells[0].Value.ToString();
//                txtName.Text = row.Cells[1].Value.ToString();
//                cboGender.Text = row.Cells[2].Value.ToString();

//                // Chuyển đổi giá trị ngày tháng từ bảng sang DateTimePicker
//                if (DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime dateValue))
//                {
//                    dtpBirthday.Value = dateValue;
//                }

//                txtID.ReadOnly = true;
//            }
//        }
//    }
//}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Article01
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối - Thay Initial Catalog bằng tên Database của bạn
        string strCon = @"Data Source=.\SQLEXPRESS;Initial Catalog=sale;Integrated Security=True";
        SqlConnection sqlCon = null;
        string currentImgPath = "";
        string oldID = ""; // Biến cực kỳ quan trọng để xử lý việc sửa mã KH

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

                    if (!string.IsNullOrEmpty(path) && File.Exists(path))
                    {
                        byte[] imgBytes = File.ReadAllBytes(path);
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            dgvCustomer.Rows[n].Cells["colAvatar"].Value = Image.FromStream(ms);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi nạp dữ liệu: " + ex.Message); }
        }

        private bool KiemTraTrungID(string id)
        {
            MoKetNoi();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM customer WHERE id = @id", sqlCon);
            cmd.Parameters.AddWithValue("@id", id);
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        // 1. CHỌN ẢNH
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Ảnh (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    currentImgPath = ofd.FileName;
                    picAvatar.Image = Image.FromFile(currentImgPath);
                }
            }
        }

        // 2. THÊM MỚI
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text.Trim();
            if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("Vui lòng nhập Mã KH!"); return; }

            if (KiemTraTrungID(id))
            {
                MessageBox.Show("Mã khách hàng này đã tồn tại!", "Lỗi trùng mã");
                return;
            }

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
                MessageBox.Show("Thêm thành công!");
                btnClear_Click(null, null);
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }

        // 3. SỬA (CHO PHÉP ĐỔI MÃ KH NHƯNG KIỂM TRA TRÙNG)
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string newID = txtID.Text.Trim();
            if (string.IsNullOrEmpty(oldID)) { MessageBox.Show("Hãy chọn một khách hàng từ danh sách để sửa!"); return; }

            try
            {
                MoKetNoi();
                // Nếu người dùng đổi sang mã mới, phải kiểm tra xem mã mới đó có ai dùng chưa
                if (newID != oldID && KiemTraTrungID(newID))
                {
                    MessageBox.Show("Mã mới này đã được sử dụng bởi khách hàng khác!", "Không thể đổi mã");
                    return;
                }

                string sql = "UPDATE customer SET id=@newID, name=@name, gender=@gender, birthday=@birthday, image_path=@img WHERE id=@oldID";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@newID", newID);
                cmd.Parameters.AddWithValue("@oldID", oldID); // Dùng mã cũ để tìm đúng dòng trong DB
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", cboGender.Text);
                cmd.Parameters.AddWithValue("@birthday", dtpBirthday.Value);
                cmd.Parameters.AddWithValue("@img", currentImgPath);

                cmd.ExecuteNonQuery();
                HienThiDanhSach();
                oldID = newID; // Cập nhật lại mã cũ sau khi sửa thành công
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa: " + ex.Message); }
        }

        // 4. XÓA
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)) return;
            if (MessageBox.Show("Xác nhận xóa?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
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

        // 5. MỚI (RESET)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtName.Clear();
            oldID = "";
            cboGender.SelectedIndex = 0;
            dtpBirthday.Value = DateTime.Now;
            picAvatar.Image = null;
            currentImgPath = "";
            txtID.Focus();
        }

        // 6. CLICK CHỌN DÒNG
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                txtID.Text = row.Cells["colID"].Value.ToString();
                oldID = txtID.Text; // LƯU LẠI MÃ TRƯỚC KHI SỬA

                txtName.Text = row.Cells["colName"].Value.ToString();
                cboGender.Text = row.Cells["colGender"].Value.ToString();
                dtpBirthday.Value = Convert.ToDateTime(row.Cells["colBirthday"].Value);

                currentImgPath = row.Cells["image_path"].Value.ToString();
                if (File.Exists(currentImgPath))
                {
                    byte[] imgBytes = File.ReadAllBytes(currentImgPath);
                    using (MemoryStream ms = new MemoryStream(imgBytes))
                    {
                        picAvatar.Image = Image.FromStream(ms);
                    }
                }
                else { picAvatar.Image = null; }
            }
        }
    }
}