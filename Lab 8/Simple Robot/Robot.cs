
using System;
using System.Drawing;

namespace Simple_Robot
{
    public enum RobotDirection
    {
        North,
        South,
        East,
        West
    }

    public class Robot
    {
        public Point Position { get; private set; }

        public RobotDirection Direction { get; set; }

        public event EventHandler? OutOfBounds;

        public Robot()
        {
            Position = new Point(0, 0);
            Direction = RobotDirection.North;
        }

        public void Move(int distance)
        {
            int newX = Position.X;
            int newY = Position.Y;

            switch (Direction)
            {
                case RobotDirection.North:
                    newY += distance;
                    break;

                case RobotDirection.South:
                    newY -= distance;
                    break;

                case RobotDirection.East:
                    newX += distance;
                    break;

                case RobotDirection.West:
                    newX -= distance;
                    break;
            }

            if (newX < -100 || newX > 100 ||
                newY < -100 || newY > 100)
            {
                OutOfBounds?.Invoke(this, EventArgs.Empty);
                return;
            }

            Position = new Point(newX, newY);
        }
    }
}
