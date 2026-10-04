using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Student_Scores
{
    public partial class UpdateStudentScore : Form
    {
        private Student student;
        public UpdateStudentScore(Student student)
        {
            InitializeComponent();
            this.student = student;
            lblStudentName.Text = student.Name;

            foreach (int score in student.Scores)
            {
                lstScores.Items.Add(score);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateScore form = new UpdateScore();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lstScores.Items.Add(form.Score);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstScores.SelectedIndex == -1)
            {
                return;
            }
            lstScores.Items.RemoveAt(lstScores.SelectedIndex);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lstScores.SelectedIndex == -1)
            {
                return;
            }
            UpdateScore form = new UpdateScore();
            if (form.ShowDialog() == DialogResult.OK)
            {
                lstScores.Items[lstScores.SelectedIndex] = form.Score;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            student.Scores.Clear();
            foreach (object item in lstScores.Items)
            {
                student.Scores.Add((int)item);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
