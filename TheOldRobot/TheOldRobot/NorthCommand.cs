﻿namespace TheOldRobot
{
    public class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered)
            {
                robot.Y++;
            }
        }
    }
}
