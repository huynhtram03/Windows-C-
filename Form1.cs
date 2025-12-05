namespace Article12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ===== Sự kiện Form Load =====
        private void Form1_Load(object sender, EventArgs e)
        {
            // Chỉ set SelectedIndex khi danh sách có đủ phần tử
            if (cb_Faculty.Items.Count > 2)
            {
                cb_Faculty.SelectedIndex = 2;
            }
        }

        // ===== Khi chọn mục trong ComboBox =====
        private void cb_Faculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Chỉ xử lý khi đã chọn mục hợp lệ
            if (cb_Faculty.SelectedIndex >= 0)
            {
                int index = cb_Faculty.SelectedIndex;
                tbDisplay.Text = "Bạn đã chọn khoa thứ: " + index.ToString();
            }
        }

        // ===== Khi nhấn nút OK =====
        private void btOK_Click(object sender, EventArgs e)
        {
            // Nếu chưa chọn -> báo lỗi
            if (cb_Faculty.SelectedItem == null)
            {
                tbDisplay.Text = "Chưa chọn khoa!";
                return;
            }

            // Lấy giá trị khoa
            string item = cb_Faculty.SelectedItem.ToString();
            tbDisplay.Text = "Bạn là sinh viên khoa : " + item;
        }
    }
}
