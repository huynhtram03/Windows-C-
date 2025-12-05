using System;
using System.Windows.Forms;

namespace Article10
{
    public partial class Form1 : Form
    {
        private string currentInput = "";   // Giá trị đang nhập
        private double numberA = 0;         // Số A
        private string operation = "";      // Toán tử (+, *)

        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện bấm nút
            btn0.Click += Number_Click;
            btn1.Click += Number_Click;
            btn2.Click += Number_Click;
            btn3.Click += Number_Click;

            btnDot.Click += Dot_Click;

            btnPlus.Click += Operation_Click;
            btnMul.Click += Operation_Click;

            btnEqual.Click += Equal_Click;
        }

        // ======== Nhập số ========
        private void Number_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                // Không cho nhập 2 số 0 đầu
                if (currentInput == "0" && btn.Text == "0") return;
                if (currentInput == "0" && btn.Text != "0") currentInput = "";

                currentInput += btn.Text;
                tbDisplay.Text = currentInput;
            }
        }

        // ======== Nhập dấu chấm ========
        private void Dot_Click(object sender, EventArgs e)
        {
            if (currentInput == "") currentInput = "0";

            if (!currentInput.Contains("."))
            {
                currentInput += ".";
                tbDisplay.Text = currentInput;
            }
        }

        // ======== Chọn toán tử ========
        private void Operation_Click(object sender, EventArgs e)
        {
            if (currentInput == "")
            {
                tbDisplay.Text = "ERROR";
                return;
            }

            if (double.TryParse(currentInput, out numberA))
            {
                if (sender is Button btn)
                {
                    operation = btn.Text;   // "+" hoặc "*"
                    currentInput = "";      // chuẩn bị nhập số B
                }
            }
            else
            {
                tbDisplay.Text = "ERROR";
                currentInput = "";
            }
        }

        // ======== Nhấn nút = ========
        private void Equal_Click(object sender, EventArgs e)
        {
            if (currentInput == "") return;

            if (!double.TryParse(currentInput, out double numberB))
            {
                tbDisplay.Text = "ERROR";
                return;
            }

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = numberA + numberB;
                    break;

                case "*":
                    result = numberA * numberB;
                    break;

                default:
                    tbDisplay.Text = "ERROR";
                    return;
            }

            tbDisplay.Text = result.ToString();

            // Cho phép bấm thêm phép tính tiếp theo
            currentInput = result.ToString();
            operation = "";
        }
    }
}
