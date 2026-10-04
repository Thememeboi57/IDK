using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Scores
{
    public partial class UpdateScore : Form
    {
        public int Score { get; private set; }
        public UpdateScore()
        {
            InitializeComponent();

        }

        private void UpdateScore_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtScore.Text, out int score))
            {
                MessageBox.Show("Please enter a valid integer score.");
                txtScore.Focus();
                return;
            }
            Score = score;
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
