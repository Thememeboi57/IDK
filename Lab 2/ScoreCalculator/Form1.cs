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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int score = int.Parse(txtScore.Text);

            scoreTotal += score;
            scoreCount++;

            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();

            int average = scoreTotal / scoreCount;
            txtAverage.Text = average.ToString();

            txtScore.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";

            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
