using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.ToyRobotApp
{
    public interface IToyRobotFunction
    {
        void ToyRobotPlace(string command);
        void ToyRobotTurn(string command);
        void ToyRobotMove();
        void ToyRobotReport();


    }
}
