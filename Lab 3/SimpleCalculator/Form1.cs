namespace SimpleCalculator
{
    public partial class SimpleCalculator : Form
    {
        public SimpleCalculator()
        {
            InitializeComponent();
        }
        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            switch (operator1)
            {
                case "+":
                    return operand1 + operand2;

                case "-":
                    return operand1 - operand2;

                case "*":
                    return operand1 * operand2;

                case "/":
                    return operand1 / operand2;

                default:
                    return 0;
            }

        }
        private void SimpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
            string operator1 = txtOperator.Text;
            decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

            decimal result = Calculate(operand1, operator1, operand2);

            txtResults.Text = result.ToString("F4");

            txtOperand1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtOperand1_TextChanged(object sender, EventArgs e)
        {
            txtResults.Clear();
        }

        private void txtOperator_TextChanged(object sender, EventArgs e)
        {
            txtResults.Clear();
        }

        private void txtOperand2_TextChanged(object sender, EventArgs e)
        {
            txtResults.Clear();
        }
    }
}
