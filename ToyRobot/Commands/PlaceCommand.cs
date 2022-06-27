using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.ToyRobotApp;

namespace ToyRobot.Commands
{
    public class PlaceCommand : ICommand
    {
        private IToyRobotFunction _toyRobotFunction;
        private string _command;
        public PlaceCommand(IToyRobotFunction toyRobotFunction, string command)
        {
            _toyRobotFunction = toyRobotFunction;
            _command = command;
        }
        public void Execute()
        {
            _toyRobotFunction.ToyRobotPlace(_command);
        }
    }
}
