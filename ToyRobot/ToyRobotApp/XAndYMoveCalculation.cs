namespace ToyRobot.ToyRobotApp
{
    public class XAndYMoveCalculation : IMoveCalculation
    {
        private readonly int _maxX;
        private readonly int _maxY;
        public XAndYMoveCalculation()
        {
            _maxX = Configurations.DOJO_X - 1;
            _maxY = Configurations.DOJO_Y - 1;
        }

        private int CalculateNewX(int current, int moveValue)
        {
            var newMoveValue = current + moveValue;
            if (newMoveValue >= 0 && newMoveValue <= _maxX)
            {
                return newMoveValue;
            }
            return current;
        }

        private int CalculateNewY(int current, int moveValue)
        {
            var newMoveValue = current + moveValue;
            if (newMoveValue >= 0 && newMoveValue <= _maxY)
            {
                return newMoveValue;
            }
            return current;
        }



        public ToyRobotStatus CalculateNewXAndY(ToyRobotStatus toyRobot)
        {

            if (toyRobot.SuccessFullyLanded)
            {
                if (toyRobot.CurrentFacingDirection == Configurations.EAST)
                {
                    toyRobot.CurrentX = CalculateNewX(toyRobot.CurrentX, Configurations.X_AXISE_PLUS_STEP);
                }
                if (toyRobot.CurrentFacingDirection == Configurations.WEST)
                {
                    toyRobot.CurrentX = CalculateNewX(toyRobot.CurrentX, Configurations.X_AXISE_MINUS_STEP);
                }

                if (toyRobot.CurrentFacingDirection == Configurations.NORTH)
                {
                    toyRobot.CurrentY = CalculateNewY(toyRobot.CurrentY, Configurations.Y_AXISE_PLUS_STEP);
                }
                if (toyRobot.CurrentFacingDirection == Configurations.SOUTH)
                {
                    toyRobot.CurrentY = CalculateNewY(toyRobot.CurrentY, Configurations.Y_AXISE_MINUS_STEP);
                } 
            }
            return toyRobot;
        }
    }
}
