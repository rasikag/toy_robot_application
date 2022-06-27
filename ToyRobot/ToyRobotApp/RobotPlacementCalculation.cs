using System;

namespace ToyRobot.ToyRobotApp
{
    public class RobotPlacementCalculation : IRobotPlacementCalculation
    {
        private readonly int _maxX;
        private readonly int _maxY;
        public RobotPlacementCalculation()
        {
            _maxX = Configurations.DOJO_X - 1;
            _maxY = Configurations.DOJO_Y - 1;
        }

        public ToyRobotStatus PlaceInTheDojo(ToyRobotStatus toyRobot, string command)
        {

            var getPlacementData = command.Split("PLACE ");
            string[] getStartEndAndFaced = null;

            if (getPlacementData.Length == 2)
            {
                getStartEndAndFaced = getPlacementData[1].Split(",");
            }
            int x;
            int y;
            bool xValidation = false;
            bool yValidation = false;
            bool faceValidation = false;
            if (!toyRobot.SuccessFullyLanded)
            {
                if (getStartEndAndFaced != null && getStartEndAndFaced.Length == 3)
                {

                    var face = getStartEndAndFaced[2];
                    CalculateXandY(getStartEndAndFaced, out x, out y, ref xValidation, ref yValidation);

                    if (face == Configurations.NORTH
                            || face == Configurations.EAST
                            || face == Configurations.WEST
                            || face == Configurations.EAST)
                    {
                        faceValidation = true;
                    }

                    if (faceValidation && xValidation && yValidation)
                    {
                        toyRobot.CurrentFacingDirection = face;
                        toyRobot.CurrentX = x;
                        toyRobot.CurrentY = y;
                        toyRobot.SuccessFullyLanded = true;
                    }
                    else
                    {
                        
                        toyRobot = new ToyRobotStatus();
                    }
                }
            }
            else
            {
                if (getStartEndAndFaced != null && getStartEndAndFaced.Length == 2)
                {
                    CalculateXandY(getStartEndAndFaced, out x, out y, ref xValidation, ref yValidation);

                    if (xValidation && yValidation)
                    {
                        toyRobot.CurrentX = x;
                        toyRobot.CurrentY = y;
                    }
                    else
                    {
                        
                        toyRobot = new ToyRobotStatus();
                    }
                }
            }

            return toyRobot;
        }

        private void CalculateXandY(string[] getStartEndAndFaced, out int x, out int y, ref bool xValidation, ref bool yValidation)
        {
            var validX = int.TryParse(getStartEndAndFaced[0], out x);
            var validY = int.TryParse(getStartEndAndFaced[1], out y);



            if (validX && x >= 0 && x <= _maxX)
            {
                xValidation = true;
            }

            if (validY && y >= 0 && y <= _maxY)
            {
                yValidation = true;
            }
        }
    }
}
