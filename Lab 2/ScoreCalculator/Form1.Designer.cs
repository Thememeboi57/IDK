namespace ScoreCalculator
{
    partial class Form1
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
            txtScore = new Label();
            txtScoreTotal = new Label();
            txtScoreCount = new Label();
            txtAverage = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Location = new Point(165, 58);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(36, 15);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score";
            txtScore.Click += txtScore_Click;
            // 
            // txtScoreTotal
            // 
            txtScoreTotal.AutoSize = true;
            txtScoreTotal.Location = new Point(150, 122);
            txtScoreTotal.Name = "txtScoreTotal";
            txtScoreTotal.Size = new Size(68, 15);
            txtScoreTotal.TabIndex = 1;
            txtScoreTotal.Text = "Score Total:";
            // 
            // txtScoreCount
            // 
            txtScoreCount.AutoSize = true;
            txtScoreCount.Location = new Point(150, 177);
            txtScoreCount.Name = "txtScoreCount";
            txtScoreCount.Size = new Size(75, 15);
            txtScoreCount.TabIndex = 2;
            txtScoreCount.Text = "Score Count:";
            // 
            // txtAverage
            // 
            txtAverage.AutoSize = true;
            txtAverage.Location = new Point(165, 225);
            txtAverage.Name = "txtAverage";
            txtAverage.Size = new Size(50, 15);
            txtAverage.TabIndex = 3;
            txtAverage.Text = "Average";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(353, 119);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(353, 177);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            textBox3.TabStop = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(353, 225);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(633, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "&Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(238, 365);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(462, 365);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txtAverage);
            Controls.Add(txtScoreCount);
            Controls.Add(txtScoreTotal);
            Controls.Add(txtScore);
            Name = "Form1";
            Text = "Score Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void txtScore_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label txtScore;
        private Label txtScoreTotal;
        private Label txtScoreCount;
        private Label txtAverage;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnAdd;
        private Button btnClear;
        private Button btnExit;
    }
}
