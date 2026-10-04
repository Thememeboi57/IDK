using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Scores
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid integer score.");
                txtScore.Focus();
                return;
            }

            if (score < 0 || score > 100)
            {
                MessageBox.Show("Score must be between 0 and 100.");
                txtScore.Focus();
                return;
            }

            txtScores.AppendText(score.ToString() + Environment.NewLine);

            txtScore.Clear();
            txtScore.Focus();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            txtScores.Clear();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name for the student.");
                txtName.Focus();
                return;
            }

            Student student = new Student(txtName.Text);

            string[] scores = txtScores.Lines;

            foreach (string scoreText in scores)
            {
                if (int.TryParse(scoreText, out int score))
                {
                    student.Scores.Add(score);
                }
            }

            this.Tag = student;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
