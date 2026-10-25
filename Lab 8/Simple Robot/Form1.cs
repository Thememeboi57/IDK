using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Robot
{
    public partial class Form1 : Form
    {
        private Robot robot = new Robot();
        public Form1()
        {
            InitializeComponent();

            robot.OutOfBounds += Robot_OutOfBounds;

            btnNorth.Click += DirectionButton_Click;
            btnSouth.Click += DirectionButton_Click;
            btnEast.Click += DirectionButton_Click;
            btnWest.Click += DirectionButton_Click;

            btnGo1.Click += btnGo1_Click;
            btnGo10.Click += btnGo10_Click;

            UpdateRobotDisplay();
        }


        private void DirectionButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button button)
                return;

            switch (button.Text)
            {
                case "N":
                    robot.Direction = RobotDirection.North;
                    break;

                case "S":
                    robot.Direction = RobotDirection.South;
                    break;

                case "E":
                    robot.Direction = RobotDirection.East;
                    break;

                case "W":
                    robot.Direction = RobotDirection.West;
                    break;
            }

            UpdateRobotDisplay();
        }

        private void btnGo1_Click(object? sender, EventArgs e)
        {
            robot.Move(1);
            UpdateRobotDisplay();
        }

        private void btnGo10_Click(object? sender, EventArgs e)
        {
            robot.Move(10);
            UpdateRobotDisplay();
        }

        private void Robot_OutOfBounds(object? sender, EventArgs e)
        {
            MessageBox.Show(
                "The robot cannot move beyond 100 units in any direction.",
                "Movement Limit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void UpdateRobotDisplay()
        {
            lblPosition.Text = "Position: (" +
                robot.Position.X + ", " +
                robot.Position.Y + ")";

            int centerX = pnlArea.ClientSize.Width / 2;
            int centerY = pnlArea.ClientSize.Height / 2;

            lblRobot.Location = new Point(
                centerX + robot.Position.X - lblRobot.Width / 2,
                centerY - robot.Position.Y - lblRobot.Height / 2);

            switch (robot.Direction)
            {
                case RobotDirection.North:
                    lblRobot.Text = ((char)233).ToString();
                    break;

                case RobotDirection.South:
                    lblRobot.Text = ((char)234).ToString();
                    break;

                case RobotDirection.East:
                    lblRobot.Text = ((char)231).ToString();
                    break;

                case RobotDirection.West:
                    lblRobot.Text = ((char)232).ToString();
                    break;
            }
        }
    }
}

    

