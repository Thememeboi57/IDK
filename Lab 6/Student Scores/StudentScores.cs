namespace Student_Scores
{
    public partial class StudentScores : Form
    {
        private List<Student> students = new List<Student>();
        public StudentScores()
        {
            InitializeComponent();
        }

        private void StudentScores_Load(object sender, EventArgs e)
        {
            Student student1 = new Student("John Smith");
            student1.Scores.Add(85);
            student1.Scores.Add(90);
            student1.Scores.Add(78);

            Student student2 = new Student("Jane Doe");
            student2.Scores.Add(95);
            student2.Scores.Add(88);

            Student student3 = new Student("Alice Johnson");
            student3.Scores.Add(72);
            student3.Scores.Add(81);
            student3.Scores.Add(91);

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            RefreshStudentList();

        }
        private void RefreshStudentList()
        {
            lstStudents.Items.Clear();

            foreach (Student student in students)
            {
                lstStudents.Items.Add(student.Name);
            }
        }

        private void lstStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                Total.Text = "";
                Count.Text = "";
                Average.Text = "";
                return;
            }
            Student student = students[lstStudents.SelectedIndex];
            lblTotal.Text = student.GetTotal().ToString();
            lblCount.Text = student.GetCount().ToString();
            lblAverage.Text = student.GetAverage().ToString("F2");
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            AddNewStudent form = new AddNewStudent();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Student student = (Student)form.Tag;
                students.Add(student);
                RefreshStudentList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                return;
            }
            students.RemoveAt(lstStudents.SelectedIndex);
            RefreshStudentList();
            lblTotal.Text = "";
            lblCount.Text = "";
            lblAverage.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(lstStudents.SelectedIndex == -1)
            {
                return;
            }
            Student student = students[lstStudents.SelectedIndex];
            UpdateStudentScore form = new UpdateStudentScore(student);
            if (form.ShowDialog() == DialogResult.OK)
            {
                lstStudents_SelectedIndexChanged(null, null);
            }
        }
    }
}
