namespace PigLatinTranslator
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
            txtInput = new TextBox();
            txtOutput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnTranslate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(198, 104);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.ScrollBars = ScrollBars.Vertical;
            txtInput.Size = new Size(379, 72);
            txtInput.TabIndex = 0;
            txtInput.TextChanged += textBox1_TextChanged;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(217, 269);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.ReadOnly = true;
            txtOutput.ScrollBars = ScrollBars.Vertical;
            txtOutput.Size = new Size(352, 81);
            txtOutput.TabIndex = 1;
            txtOutput.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(366, 54);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Enter Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 208);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 3;
            label2.Text = "Pig Latin";
            // 
            // btnTranslate
            // 
            btnTranslate.Location = new Point(260, 382);
            btnTranslate.Name = "btnTranslate";
            btnTranslate.Size = new Size(75, 23);
            btnTranslate.TabIndex = 4;
            btnTranslate.Text = "&Translate";
            btnTranslate.UseVisualStyleBackColor = true;
            btnTranslate.Click += btnTranslate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(445, 382);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 5;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AcceptButton = btnTranslate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnClear;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnTranslate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtOutput);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Pig Latin Translator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtOutput;
        private Label label1;
        private Label label2;
        private Button btnTranslate;
        private Button btnClear;
    }
}
