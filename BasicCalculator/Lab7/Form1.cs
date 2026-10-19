using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace Lab7
{
    public partial class Form1 : Form
    {
        private Calculator calculator = new Calculator();
        private bool startNewNumber = true;
        public Form1()
        {
            InitializeComponent();
            btnAdd.Click += OperatorButton_Click;
            btnSubtract.Click += OperatorButton_Click;
            btnMultiply.Click += OperatorButton_Click;
            btnDivide.Click += OperatorButton_Click;
            btn0.Click += NumberButton_Click;
            btn1.Click += NumberButton_Click;
            btn2.Click += NumberButton_Click;
            btn3.Click += NumberButton_Click;
            btn4.Click += NumberButton_Click;
            btn5.Click += NumberButton_Click;
            btn6.Click += NumberButton_Click;
            btn7.Click += NumberButton_Click;
            btn8.Click += NumberButton_Click;
            btn9.Click += NumberButton_Click;

        }
        private void OperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            calculator.SetValue(decimal.Parse(txtDisplay.Text));
            calculator.SetOperation(button.Text);
            startNewNumber = true;
        }
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (startNewNumber || txtDisplay.Text == "0")
            {
                txtDisplay.Text = button.Text;
                startNewNumber = false;
            }
            else
            {
                txtDisplay.Text += button.Text;
            }
            calculator.SetValue(decimal.Parse(txtDisplay.Text));
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                decimal result;
                if (startNewNumber)
                {
                    result = calculator.RepeatOperation();
                }
                else
                {
                    result = calculator.Calculate(decimal.Parse(txtDisplay.Text));
                }

                txtDisplay.Text = result.ToString();
                startNewNumber = true;
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Cannot divide by zero.";
                calculator.Clear();
                startNewNumber = true;
            }
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.SetValue(decimal.Parse(txtDisplay.Text));
                txtDisplay.Text = calculator.SquareRoot().ToString();
                startNewNumber = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                txtDisplay.Text = "Invalid input";
                calculator.Clear();
                startNewNumber = true;
            }
        }
        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {
                calculator.SetValue(decimal.Parse(txtDisplay.Text));
                txtDisplay.Text = calculator.Reciprocal().ToString();
                startNewNumber = true;
            }
            catch (DivideByZeroException)
            {
                txtDisplay.Text = "Cannot divide by zero";
                calculator.Clear();
                startNewNumber = true;
            }
        }
        private void btnSign_Click(object sender, EventArgs e)
        {
            calculator.SetValue(decimal.Parse(txtDisplay.Text));
            calculator.ChangeSign();
            txtDisplay.Text = calculator.Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            txtDisplay.Text = "0";
            startNewNumber = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (startNewNumber)
            {
                return;
            }
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            }
            else
            {
                txtDisplay.Text = "0";
            }
            calculator.SetValue(decimal.Parse(txtDisplay.Text));
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (startNewNumber)
            {
                txtDisplay.Text = "0.";
                startNewNumber = false;
            }
            else if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
            }
        }
    }
}
