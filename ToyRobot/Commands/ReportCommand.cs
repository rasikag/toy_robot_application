using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.ToyRobotApp;

namespace ToyRobot.Commands
{
    public class ReportCommand : ICommand
    {
        private IToyRobotFunction _toyRobotFunction;
        public ReportCommand(IToyRobotFunction toyRobotFunction)
        {
            _toyRobotFunction = toyRobotFunction;
        }
        public void Execute()
        {
            _toyRobotFunction.ToyRobotReport();
        }
    }
}
