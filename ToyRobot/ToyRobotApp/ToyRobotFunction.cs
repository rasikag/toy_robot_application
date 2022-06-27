using System;

namespace ToyRobot.ToyRobotApp
{
    public class ToyRobotFunction : IToyRobotFunction
    {
        private readonly IFaceDirectionCalculation _faceDirectionCal;
        private readonly IRobotPlacementCalculation _robotPlacementCal;
        private readonly IMoveCalculation _moveCal;
        private ToyRobotStatus _status;
        public ToyRobotFunction()
        {
            _faceDirectionCal = new FaceDirectionCalculation();
            _robotPlacementCal = new RobotPlacementCalculation();
            _moveCal = new XAndYMoveCalculation();

            _status = new ToyRobotStatus();
        }

        public void ToyRobotMove()
        {
            _status = _moveCal.CalculateNewXAndY(_status);
        }

        public void ToyRobotPlace(string command)
        {
            _status = _robotPlacementCal.PlaceInTheDojo(_status, command);
        }

        public void ToyRobotTurn(string command)
        {
            _status = _faceDirectionCal.CalculateNewFaceDirection(_status, command);
        }

        public void ToyRobotReport()
        {
            if (_status.SuccessFullyLanded)
            {
                string output = $"Output: {_status.CurrentX},{_status.CurrentY},{_status.CurrentFacingDirection}";
                Console.WriteLine(output);
            }

        }
    }
}
