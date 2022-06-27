using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.ToyRobotApp;

namespace ToyRobot.Commands
{
    public class TurnCommand : ICommand
    {
        private IToyRobotFunction _toyRobotFunctions;
        private string _command;
        public TurnCommand(IToyRobotFunction toyRobotFunctions, string command)
        {
            _toyRobotFunctions = toyRobotFunctions;
            _command = command;
        }

        public void Execute()
        {
            _toyRobotFunctions.ToyRobotTurn(_command);
        }
    }
}
