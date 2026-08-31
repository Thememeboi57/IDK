namespace ScoreCalculator
{
    public partial class Form1 : Form
    {
        private int scoreTotal = 0;
        private int scoreCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int score;
        int average;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int parsedScore))
            {
                score = parsedScore;
            }
            else
            {
                score = 0;
            }

            scoreTotal += score;
            scoreCount++;

            textBox2.Text = scoreTotal.ToString();
            textBox3.Text = scoreCount.ToString();

            average = scoreTotal / scoreCount;
            textBox4.Text = average.ToString();

            textBox1.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
