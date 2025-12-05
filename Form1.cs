using System;
using System.Windows.Forms;

namespace Article11
{
    public partial class Form1 : Form
    {
        decimal memory = 0;        // M+, M-, MR, MC
        decimal workingMemory = 0; // Lưu A
        string opr = "";           // Toán tử

        public Form1()
        {
            InitializeComponent();
        }

        // =================== Xử lý tất cả button ===================
        private void Button_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;

            // ===== SỐ và DẤU CHẤM =====
            if (char.IsDigit(bt.Text, 0) || bt.Text == ".")
            {
                if (bt.Text == ".")
                {
                    if (txtDisplay.Text == "") txtDisplay.Text = "0";
                    if (txtDisplay.Text.Contains(".")) return;
                }

                txtDisplay.Text += bt.Text;
                return;
            }

            // ===== TOÁN TỬ =====
            if (bt.Text == "+" || bt.Text == "-" || bt.Text == "*" || bt.Text == "/")
            {
                if (txtDisplay.Text == "") return;

                workingMemory = decimal.Parse(txtDisplay.Text);
                opr = bt.Text;
                txtDisplay.Clear();
                return;
            }

            // ===== DẤU = =====
            if (bt.Text == "=")
            {
                if (txtDisplay.Text == "" || opr == "") return;

                decimal secondValue = decimal.Parse(txtDisplay.Text);
                decimal result = 0;

                try
                {
                    switch (opr)
                    {
                        case "+": result = workingMemory + secondValue; break;
                        case "-": result = workingMemory - secondValue; break;
                        case "*": result = workingMemory * secondValue; break;
                        case "/":
                            if (secondValue == 0)
                            {
                                txtDisplay.Text = "Error";
                                return;
                            }
                            result = workingMemory / secondValue;
                            break;
                    }

                    txtDisplay.Text = result.ToString();
                }
                catch
                {
                    txtDisplay.Text = "Error";
                }

                return;
            }

            // ===== BACKSPACE =====
            if (bt.Text == "←")
            {
                if (txtDisplay.Text.Length > 0)
                    txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
                return;
            }

            // ===== CLEAR ALL =====
            if (bt.Text == "C")
            {
                workingMemory = 0;
                opr = "";
                txtDisplay.Clear();
                return;
            }

            // ===== CLEAR ENTRY =====
            if (bt.Text == "CE")
            {
                txtDisplay.Clear();
                return;
            }

            // ===== ĐỔI DẤU =====
            if (bt.Text == "±")
            {
                if (txtDisplay.Text == "") return;

                decimal curr = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (-curr).ToString();
                return;
            }

            // ===== CĂN BẬC 2 =====
            if (bt.Text == "√")
            {
                if (txtDisplay.Text == "") return;

                decimal curr = decimal.Parse(txtDisplay.Text);
                double sqrt = Math.Sqrt((double)curr);

                txtDisplay.Text = ((decimal)sqrt).ToString();
                return;
            }

            // ===== PHẦN TRĂM =====
            if (bt.Text == "%")
            {
                if (txtDisplay.Text == "") return;

                decimal curr = decimal.Parse(txtDisplay.Text);
                txtDisplay.Text = (curr / 100).ToString();
                return;
            }

            // ===== 1 / X =====
            if (bt.Text == "1/x")
            {
                if (txtDisplay.Text == "") return;

                decimal curr = decimal.Parse(txtDisplay.Text);

                if (curr == 0)
                {
                    txtDisplay.Text = "Error";
                    return;
                }

                txtDisplay.Text = (1 / curr).ToString();
                return;
            }

            // ===== MEMORY =====
            if (bt.Text == "MC") memory = 0;
            else if (bt.Text == "MR") txtDisplay.Text = memory.ToString();
            else if (bt.Text == "MS")
            {
                if (txtDisplay.Text != "")
                    memory = decimal.Parse(txtDisplay.Text);
            }
            else if (bt.Text == "M+" && txtDisplay.Text != "")
                memory += decimal.Parse(txtDisplay.Text);
            else if (bt.Text == "M-" && txtDisplay.Text != "")
                memory -= decimal.Parse(txtDisplay.Text);
        }
    }
}
