using System;
using System.Collections.Generic;
using ToyRobot.Commands;
using ToyRobot.ToyRobotApp;

namespace ToyRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> userCommands = new List<string>();
            Console.WriteLine("Please enter commands: ");
            Console.WriteLine();
            string input = Console.ReadLine();
            while (true)
            {
                userCommands.Add(input);
                if (input.Trim() == Configurations.REPORT)
                {
                    break;
                }
                input = Console.ReadLine();
            }

            IToyRobotFunction robotFunction = new ToyRobotFunction();

            CalculateFinalStatus(userCommands, robotFunction);

            Console.ReadLine();
        }

        private static void CalculateFinalStatus(List<string> userCommands, IToyRobotFunction function)
        {
            List<ICommand> commands = new List<ICommand>();
            foreach (var userCommand in userCommands)
            {
                if (userCommand.StartsWith(Configurations.PLACE))
                {
                    commands.Add(new PlaceCommand(function, userCommand));
                }

                if (userCommand.Trim() == Configurations.MOVE)
                {
                    commands.Add(new MoveCommand(function));
                }

                if (userCommand.Trim() == Configurations.LEFT || userCommand.Trim() == Configurations.RIGHT)
                {
                    commands.Add(new TurnCommand(function, userCommand));
                }

                if (userCommand.Trim() == Configurations.REPORT)
                {
                    commands.Add(new ReportCommand(function));
                }
            }

            foreach (var command in commands)
            {
                command.Execute();
            }

        }
    }
}
