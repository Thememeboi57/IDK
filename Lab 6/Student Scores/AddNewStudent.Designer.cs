namespace Student_Scores
{
    partial class AddNewStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAddScore = new Button();
            btnClearScores = new Button();
            btnOK = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            txtScore = new TextBox();
            txtScores = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 75);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 137);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Score:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 207);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 2;
            label3.Text = "Scores:";
            // 
            // btnAddScore
            // 
            btnAddScore.Location = new Point(492, 151);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(75, 23);
            btnAddScore.TabIndex = 3;
            btnAddScore.Text = "Add Score";
            btnAddScore.UseVisualStyleBackColor = true;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // btnClearScores
            // 
            btnClearScores.Location = new Point(492, 223);
            btnClearScores.Name = "btnClearScores";
            btnClearScores.Size = new Size(75, 23);
            btnClearScores.TabIndex = 4;
            btnClearScores.Text = "Clear Scores";
            btnClearScores.UseVisualStyleBackColor = true;
            btnClearScores.Click += btnClearScores_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(236, 403);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(465, 403);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(211, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 7;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(236, 137);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 8;
            // 
            // txtScores
            // 
            txtScores.Location = new Point(254, 204);
            txtScores.Name = "txtScores";
            txtScores.ReadOnly = true;
            txtScores.Size = new Size(100, 23);
            txtScores.TabIndex = 9;
            // 
            // AddNewStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 450);
            Controls.Add(txtScores);
            Controls.Add(txtScore);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(btnClearScores);
            Controls.Add(btnAddScore);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddNewStudent";
            Text = "Add New Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAddScore;
        private Button btnClearScores;
        private Button btnOK;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtScore;
        private TextBox txtScores;
    }
}