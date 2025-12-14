using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Article24
{
    public partial class Form1 : Form
    {
        private int seconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            seconds = 0;
            lbTime.Text = "00:00";
            btStart.Enabled = false;
            btStop.Enabled = true;
            timer1.Start();
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btStart.Enabled = true;
            btStop.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            int minute = seconds / 60;
            int sec = seconds % 60;
            lbTime.Text = $"{minute:00}:{sec:00}";
        }
    }
}
