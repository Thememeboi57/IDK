namespace Simple_Robot
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
            lblPosition = new Label();
            pnlArea = new Panel();
            lblRobot = new Label();
            btnNorth = new Button();
            btnSouth = new Button();
            btnEast = new Button();
            btnWest = new Button();
            btnGo1 = new Button();
            btnGo10 = new Button();
            pnlArea.SuspendLayout();
            SuspendLayout();
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(145, 29);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(82, 15);
            lblPosition.TabIndex = 0;
            lblPosition.Text = "Position: (0, 0)";
            // 
            // pnlArea
            // 
            pnlArea.Controls.Add(lblRobot);
            pnlArea.Location = new Point(81, 57);
            pnlArea.Name = "pnlArea";
            pnlArea.Size = new Size(200, 176);
            pnlArea.TabIndex = 1;
            // 
            // lblRobot
            // 
            lblRobot.Font = new Font("Wingdings", 18F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblRobot.Location = new Point(86, 39);
            lblRobot.Name = "lblRobot";
            lblRobot.Size = new Size(30, 30);
            lblRobot.TabIndex = 0;
            lblRobot.Text = "ñ";
            lblRobot.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNorth
            // 
            btnNorth.Location = new Point(167, 256);
            btnNorth.Name = "btnNorth";
            btnNorth.Size = new Size(29, 23);
            btnNorth.TabIndex = 2;
            btnNorth.Text = "N";
            btnNorth.UseVisualStyleBackColor = true;
            // 
            // btnSouth
            // 
            btnSouth.Location = new Point(167, 299);
            btnSouth.Name = "btnSouth";
            btnSouth.Size = new Size(29, 23);
            btnSouth.TabIndex = 3;
            btnSouth.Text = "S";
            btnSouth.UseVisualStyleBackColor = true;
            // 
            // btnEast
            // 
            btnEast.Location = new Point(192, 279);
            btnEast.Name = "btnEast";
            btnEast.Size = new Size(24, 23);
            btnEast.TabIndex = 4;
            btnEast.Text = "E";
            btnEast.UseVisualStyleBackColor = true;
            // 
            // btnWest
            // 
            btnWest.Location = new Point(145, 279);
            btnWest.Name = "btnWest";
            btnWest.Size = new Size(21, 23);
            btnWest.TabIndex = 5;
            btnWest.Text = "W";
            btnWest.UseVisualStyleBackColor = true;
            // 
            // btnGo1
            // 
            btnGo1.Location = new Point(64, 279);
            btnGo1.Name = "btnGo1";
            btnGo1.Size = new Size(75, 23);
            btnGo1.TabIndex = 6;
            btnGo1.Text = "Go 1";
            btnGo1.UseVisualStyleBackColor = true;
            // 
            // btnGo10
            // 
            btnGo10.Location = new Point(222, 279);
            btnGo10.Name = "btnGo10";
            btnGo10.Size = new Size(75, 23);
            btnGo10.TabIndex = 7;
            btnGo10.Text = "Go 10";
            btnGo10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 387);
            Controls.Add(btnGo10);
            Controls.Add(btnGo1);
            Controls.Add(btnWest);
            Controls.Add(btnEast);
            Controls.Add(btnSouth);
            Controls.Add(btnNorth);
            Controls.Add(pnlArea);
            Controls.Add(lblPosition);
            Name = "Form1";
            Text = "Robot";
            pnlArea.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPosition;
        private Panel pnlArea;
        private Label lblRobot;
        private Button btnNorth;
        private Button btnSouth;
        private Button btnEast;
        private Button btnWest;
        private Button btnGo1;
        private Button btnGo10;
    }
}
