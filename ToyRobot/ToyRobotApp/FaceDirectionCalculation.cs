using System;
using System.Collections.Generic;
using System.Text;

namespace ToyRobot.ToyRobotApp
{
    internal class FaceDirectionCalculation : IFaceDirectionCalculation
    {
        

        public ToyRobotStatus CalculateNewFaceDirection(ToyRobotStatus toyRobot, string command)
        {

            bool calculated = false;
            if (toyRobot.SuccessFullyLanded)
            {
                if (toyRobot.CurrentFacingDirection == Configurations.NORTH && !calculated)
                {
                    toyRobot.CurrentFacingDirection = command == Configurations.LEFT ? Configurations.WEST : Configurations.EAST;
                    calculated = true;
                }

                if (toyRobot.CurrentFacingDirection == Configurations.EAST && !calculated)
                {
                    toyRobot.CurrentFacingDirection = command == Configurations.LEFT ? Configurations.NORTH : Configurations.SOUTH;
                    calculated = true;
                }

                if (toyRobot.CurrentFacingDirection == Configurations.SOUTH && !calculated)
                {
                    toyRobot.CurrentFacingDirection = command == Configurations.LEFT ? Configurations.EAST : Configurations.WEST;
                    calculated = true;
                }

                if (toyRobot.CurrentFacingDirection == Configurations.WEST && !calculated)
                {
                    toyRobot.CurrentFacingDirection = command == Configurations.LEFT ? Configurations.SOUTH : Configurations.NORTH;
                    calculated = true;
                } 
            }

            return toyRobot;
        }
    }
}
