using Article18.Article18;
using System;
using System.Collections;
using System.Windows.Forms;

namespace Article18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tạo dữ liệu bài hát
        public ArrayList GetData()
        {
            ArrayList lst = new ArrayList();

            Song s = new Song();
            s.Id = 53418;
            s.Name = "Giấc mơ Chapi";
            s.Author = "Trần Tiến";
            lst.Add(s);

            s = new Song();
            s.Id = 52616;
            s.Name = "Đôi mắt Pleiku";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            s = new Song();
            s.Id = 51172;
            s.Name = "Em muốn sống bên anh trọn đời";
            s.Author = "Nguyễn Cường";
            lst.Add(s);

            return lst;
        }

        // ===============================
        //   FORM LOAD (KHÔNG DÙNG DataSource)
        // ===============================
        private void Form1_Load(object sender, EventArgs e)
        {
            ArrayList lst = GetData();

            // Không dùng DataSource để tránh lỗi Items.Add/Remove
            foreach (Song s in lst)
            {
                lbSong.Items.Add(s);
            }

            lbSong.DisplayMember = "Name";
            lbFavorite.DisplayMember = "Name";
        }

        // BUTTON >
        private void btSelect_Click(object sender, EventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                Song song = (Song)lbSong.SelectedItem;
                lbFavorite.Items.Add(song);
                lbSong.Items.Remove(song);
            }
        }

        // BUTTON <
        private void btDeselect_Click(object sender, EventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                Song song = (Song)lbFavorite.SelectedItem;
                lbSong.Items.Add(song);
                lbFavorite.Items.Remove(song);
            }
        }

        // BUTTON >>
        private void btSelectAll_Click(object sender, EventArgs e)
        {
            while (lbSong.Items.Count > 0)
            {
                lbFavorite.Items.Add(lbSong.Items[0]);
                lbSong.Items.RemoveAt(0);
            }
        }

        // BUTTON <<
        private void btDeselectAll_Click(object sender, EventArgs e)
        {
            while (lbFavorite.Items.Count > 0)
            {
                lbSong.Items.Add(lbFavorite.Items[0]);
                lbFavorite.Items.RemoveAt(0);
            }
        }

        // Double click chọn bài hát
        private void lbSong_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbSong.SelectedItem != null)
            {
                Song s = (Song)lbSong.SelectedItem;
                lbFavorite.Items.Add(s);
                lbSong.Items.Remove(s);
            }
        }

        // Double click bỏ chọn bài hát
        private void lbFavorite_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbFavorite.SelectedItem != null)
            {
                Song s = (Song)lbFavorite.SelectedItem;
                lbSong.Items.Add(s);
                lbFavorite.Items.Remove(s);
            }
        }
    }
}
