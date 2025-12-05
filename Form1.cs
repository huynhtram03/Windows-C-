namespace Article17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Bài hát mẫu
            lbSong.Items.AddRange(new string[]
            {
                "Giấc mơ Chapi",
                "Dế Mèn Phiêu Lưu",
                "Em Muốn Sống Bên Anh Trọn Đời",
                "H'Zen Lên Rẫy",
                "Còn Thương Nhau Thì Về Buôn Mê Thuột",
                "Lý Cà Phê Ban Mê",
                "Đi tìm lời ru mặt trời"
            });
        }

        // BUTTON >
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedIndex != -1)
            {
                string song = lbSong.SelectedItem.ToString();
                lbFavorite.Items.Add(song);
                lbSong.Items.RemoveAt(lbSong.SelectedIndex);
            }
        }

        // BUTTON <
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedIndex != -1)
            {
                string song = lbFavorite.SelectedItem.ToString();
                lbSong.Items.Add(song);
                lbFavorite.Items.RemoveAt(lbFavorite.SelectedIndex);
            }
        }

        // BUTTON >>
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbSong.Items.Count - 1; i >= 0; i--)
            {
                lbFavorite.Items.Add(lbSong.Items[i].ToString());
                lbSong.Items.RemoveAt(i);
            }
        }

        // BUTTON <<
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            for (int i = lbFavorite.Items.Count - 1; i >= 0; i--)
            {
                lbSong.Items.Add(lbFavorite.Items[i].ToString());
                lbFavorite.Items.RemoveAt(i);
            }
        }

        // Double Click → chuyển qua phải
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbSong.IndexFromPoint(e.Location);
            if (index != -1)
            {
                lbFavorite.Items.Add(lbSong.Items[index]);
                lbSong.Items.RemoveAt(index);
            }
        }

        // Double Click → chuyển về trái
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lbFavorite.IndexFromPoint(e.Location);
            if (index != -1)
            {
                lbSong.Items.Add(lbFavorite.Items[index]);
                lbFavorite.Items.RemoveAt(index);
            }
        }
    }
}
