using System;
using System.Windows.Forms;

namespace MyCalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Helper method to check inputs. This prevents the app from crashing if letters are typed.
        private bool GetInputs(out double first, out double second, bool requireSecond = true)
        {
            second = 0;
            bool isFirstValid = double.TryParse(txtFirst.Text, out first);
            bool isSecondValid = !requireSecond || double.TryParse(txtSecond.Text, out second);

            if (!isFirstValid || (!isSecondValid && requireSecond))
            {
                MessageBox.Show("Invalid input! Only numbers are allowed.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        // Helper method to display the result and add it to the ListBox history
        private void LogHistory(string operation, double result)
        {
            txtResult.Text = result.ToString();
            lstHistory.Items.Add($"{operation} = {result}");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
                LogHistory($"{first} + {second}", first + second);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
                LogHistory($"{first} - {second}", first - second);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
                LogHistory($"{first} * {second}", first * second);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
            {
                if (second == 0)
                {
                    MessageBox.Show("Division by zero is not possible!!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                LogHistory($"{first} / {second}", first / second);
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
            {
                if (second == 0)
                {
                    MessageBox.Show("Division by zero is not possible!!", "Math Error");
                    return;
                }
                LogHistory($"{first} % {second}", first % second);
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
                LogHistory($"{first} ^ {second}", Math.Pow(first, second));
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            // Square root only needs the first number, so we pass "false" for requireSecond
            if (GetInputs(out double first, out double second, false))
            {
                if (first < 0)
                {
                    MessageBox.Show("Cannot calculate square root of a negative number!");
                    return;
                }
                txtSecond.Clear();
                txtSecond.Enabled = false;
                LogHistory($"Sqrt({first})", Math.Sqrt(first));
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
                LogHistory($"MINIMUM({first}, {second})", Math.Min(first, second));
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (GetInputs(out double first, out double second))
                LogHistory($"MAXIMUM({first}, {second})", Math.Max(first, second));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirst.Clear();
            txtSecond.Clear();
            txtResult.Clear();
            txtSecond.Enabled = true; // Re-enable in case Sqrt disabled it
            txtFirst.Focus();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            lstHistory.Items.Clear();
            txtSecond.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}