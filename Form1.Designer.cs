namespace Article17
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button btSelect;
        private System.Windows.Forms.Button btDeselect;
        private System.Windows.Forms.Button btSelectAll;
        private System.Windows.Forms.Button btDeselectAll;

        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.ListBox lbFavorite;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btSelect = new System.Windows.Forms.Button();
            this.btDeselect = new System.Windows.Forms.Button();
            this.btSelectAll = new System.Windows.Forms.Button();
            this.btDeselectAll = new System.Windows.Forms.Button();

            this.lbSong = new System.Windows.Forms.ListBox();
            this.lbFavorite = new System.Windows.Forms.ListBox();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // label1
            this.label1.Text = "Danh sách bài hát";
            this.label1.Location = new System.Drawing.Point(30, 10);

            // label2
            this.label2.Text = "Danh sách bài hát ưa thích";
            this.label2.Location = new System.Drawing.Point(350, 10);

            // lbSong
            this.lbSong.Location = new System.Drawing.Point(30, 30);
            this.lbSong.Size = new System.Drawing.Size(200, 250);
            this.lbSong.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbSong_MouseDoubleClick);

            // lbFavorite
            this.lbFavorite.Location = new System.Drawing.Point(350, 30);
            this.lbFavorite.Size = new System.Drawing.Size(200, 250);
            this.lbFavorite.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbFavorite_MouseDoubleClick);

            // btSelect >
            this.btSelect.Text = ">";
            this.btSelect.Location = new System.Drawing.Point(260, 50);
            this.btSelect.Size = new System.Drawing.Size(60, 30);
            this.btSelect.Click += new System.EventHandler(this.btSelect_Click);

            // btDeselect <
            this.btDeselect.Text = "<";
            this.btDeselect.Location = new System.Drawing.Point(260, 100);
            this.btDeselect.Size = new System.Drawing.Size(60, 30);
            this.btDeselect.Click += new System.EventHandler(this.btDeselect_Click);

            // btSelectAll >>
            this.btSelectAll.Text = ">>";
            this.btSelectAll.Location = new System.Drawing.Point(260, 150);
            this.btSelectAll.Size = new System.Drawing.Size(60, 30);
            this.btSelectAll.Click += new System.EventHandler(this.btSelectAll_Click);

            // btDeselectAll <<
            this.btDeselectAll.Text = "<<";
            this.btDeselectAll.Location = new System.Drawing.Point(260, 200);
            this.btDeselectAll.Size = new System.Drawing.Size(60, 30);
            this.btDeselectAll.Click += new System.EventHandler(this.btDeselectAll_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);

            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.lbFavorite);

            this.Controls.Add(this.btSelect);
            this.Controls.Add(this.btDeselect);
            this.Controls.Add(this.btSelectAll);
            this.Controls.Add(this.btDeselectAll);

            this.Text = "Music";
            this.ResumeLayout(false);
        }
    }
}
