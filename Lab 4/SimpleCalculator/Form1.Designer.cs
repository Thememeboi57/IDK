namespace SimpleCalculator
{
    partial class SimpleCalculator
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
            txtOperand1 = new TextBox();
            txtOperator = new TextBox();
            txtOperand2 = new TextBox();
            txtResults = new TextBox();
            Operand1 = new Label();
            Operator = new Label();
            Operand2 = new Label();
            Result = new Label();
            btnCalculate = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtOperand1
            // 
            txtOperand1.Location = new Point(401, 73);
            txtOperand1.Name = "txtOperand1";
            txtOperand1.Size = new Size(100, 23);
            txtOperand1.TabIndex = 0;
            // 
            // txtOperator
            // 
            txtOperator.Location = new Point(401, 137);
            txtOperator.Name = "txtOperator";
            txtOperator.Size = new Size(100, 23);
            txtOperator.TabIndex = 1;
            // 
            // txtOperand2
            // 
            txtOperand2.Location = new Point(401, 201);
            txtOperand2.Name = "txtOperand2";
            txtOperand2.Size = new Size(100, 23);
            txtOperand2.TabIndex = 2;
            // 
            // txtResults
            // 
            txtResults.Location = new Point(401, 264);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(100, 23);
            txtResults.TabIndex = 3;
            // 
            // Operand1
            // 
            Operand1.AutoSize = true;
            Operand1.Location = new Point(135, 76);
            Operand1.Name = "Operand1";
            Operand1.Size = new Size(62, 15);
            Operand1.TabIndex = 4;
            Operand1.Text = "Operand 1";
            // 
            // Operator
            // 
            Operator.AutoSize = true;
            Operator.Location = new Point(143, 137);
            Operator.Name = "Operator";
            Operator.Size = new Size(54, 15);
            Operator.TabIndex = 5;
            Operator.Text = "Operator";
            // 
            // Operand2
            // 
            Operand2.AutoSize = true;
            Operand2.Location = new Point(143, 201);
            Operand2.Name = "Operand2";
            Operand2.Size = new Size(62, 15);
            Operand2.TabIndex = 6;
            Operand2.Text = "Operand 2";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(150, 264);
            Result.Name = "Result";
            Result.Size = new Size(39, 15);
            Result.TabIndex = 7;
            Result.Text = "Result";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(165, 355);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(390, 355);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // SimpleCalculator
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(595, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCalculate);
            Controls.Add(Result);
            Controls.Add(Operand2);
            Controls.Add(Operator);
            Controls.Add(Operand1);
            Controls.Add(txtResults);
            Controls.Add(txtOperand2);
            Controls.Add(txtOperator);
            Controls.Add(txtOperand1);
            Name = "SimpleCalculator";
            Text = "Simple Calculator";
            Load += SimpleCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOperand1;
        private TextBox txtOperator;
        private TextBox txtOperand2;
        private TextBox txtResults;
        private Label Operand1;
        private Label Operator;
        private Label Operand2;
        private Label Result;
        private Button btnCalculate;
        private Button btnExit;
    }
}
