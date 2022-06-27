namespace ToyRobot.ToyRobotApp
{
    public interface IMoveCalculation : ICalculation
    {

        // int CalculateNewX(int current, int moveValue);
        // int CalculateNewY(int current, int moveValue);
        // int CalculateXAxisMoveValue(string currentFace);
        // int CalculateYAxisMoveValue(string currentFace);
        ToyRobotStatus CalculateNewXAndY(ToyRobotStatus toyRobot);
    }
}