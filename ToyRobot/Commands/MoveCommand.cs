using System;
using System.Collections.Generic;
using System.Text;
using ToyRobot.ToyRobotApp;

namespace ToyRobot.Commands
{
    public class MoveCommand : ICommand
    {
        private IToyRobotFunction _robotFunction;
        public MoveCommand(IToyRobotFunction toyRobot)
        {
            _robotFunction = toyRobot;
        }
        public void Execute()
        {
            _robotFunction.ToyRobotMove();
        }
    }
}
