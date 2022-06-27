namespace ToyRobot.ToyRobotApp
{
    public interface IRobotPlacementCalculation : ICalculation
    {
        ToyRobotStatus PlaceInTheDojo(ToyRobotStatus status, string command);
    }
}