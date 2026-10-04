namespace Student_Scores
{
    partial class StudentScores
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAddNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            Total = new Label();
            Count = new Label();
            Average = new Label();
            lstStudents = new ListBox();
            lblTotal = new TextBox();
            lblCount = new TextBox();
            lblAverage = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(206, 42);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Students";
            // 
            // btnAddNew
            // 
            btnAddNew.Location = new Point(415, 94);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(75, 23);
            btnAddNew.TabIndex = 2;
            btnAddNew.Text = "Add New";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(415, 136);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(415, 180);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(415, 397);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(272, 281);
            Total.Name = "Total";
            Total.Size = new Size(66, 15);
            Total.TabIndex = 6;
            Total.Text = "Score total:";
            // 
            // Count
            // 
            Count.AutoSize = true;
            Count.Location = new Point(265, 317);
            Count.Name = "Count";
            Count.Size = new Size(73, 15);
            Count.TabIndex = 7;
            Count.Text = "Score count:";
            // 
            // Average
            // 
            Average.AutoSize = true;
            Average.Location = new Point(272, 351);
            Average.Name = "Average";
            Average.Size = new Size(53, 15);
            Average.TabIndex = 8;
            Average.Text = "Average:";
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.Location = new Point(176, 109);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(120, 94);
            lstStudents.TabIndex = 9;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // lblTotal
            // 
            lblTotal.Location = new Point(407, 278);
            lblTotal.Name = "lblTotal";
            lblTotal.ReadOnly = true;
            lblTotal.Size = new Size(100, 23);
            lblTotal.TabIndex = 10;
            // 
            // lblCount
            // 
            lblCount.Location = new Point(404, 314);
            lblCount.Name = "lblCount";
            lblCount.ReadOnly = true;
            lblCount.Size = new Size(100, 23);
            lblCount.TabIndex = 11;
            // 
            // lblAverage
            // 
            lblAverage.Location = new Point(407, 348);
            lblAverage.Name = "lblAverage";
            lblAverage.ReadOnly = true;
            lblAverage.Size = new Size(100, 23);
            lblAverage.TabIndex = 12;
            // 
            // StudentScores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(516, 432);
            Controls.Add(lblAverage);
            Controls.Add(lblCount);
            Controls.Add(lblTotal);
            Controls.Add(lstStudents);
            Controls.Add(Average);
            Controls.Add(Count);
            Controls.Add(Total);
            Controls.Add(btnExit);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Name = "StudentScores";
            Text = "Student Scores";
            Load += StudentScores_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnAddNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnExit;
        private Label Total;
        private Label Count;
        private Label Average;
        private ListBox lstStudents;
        private TextBox lblTotal;
        private TextBox lblCount;
        private TextBox lblAverage;
    }
}
