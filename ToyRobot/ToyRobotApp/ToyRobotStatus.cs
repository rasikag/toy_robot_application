using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.ToyRobotApp
{
    public class ToyRobotStatus
    {
        public int CurrentX { get; set; } = -1;
        public int CurrentY { get; set; } = -1;
        public string CurrentFacingDirection { get; set; } = "";
        public bool SuccessFullyLanded { get; set; } = false;
    }
}
