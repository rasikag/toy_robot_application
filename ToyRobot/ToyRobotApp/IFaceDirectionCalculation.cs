using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.ToyRobotApp
{
    public interface IFaceDirectionCalculation : ICalculation
    {
        ToyRobotStatus CalculateNewFaceDirection(ToyRobotStatus toyRobot, string command);
    }
}
