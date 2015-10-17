using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{


    /// <summary>
    /// Factory class to create command objects based on given string
    /// </summary>
    public class CommandFactory
    {


        public ICommand create(string cmd)
        {
            // Split the command and parameters if any
            string[] commandargs = cmd.Trim().Split(' ');
            // select the command object
            switch (commandargs[0].ToUpper())
            {
                case "MOVE":
                    return new MoveCommand();
                case "LEFT":
                    return new LeftCommand();
                case "RIGHT":
                    return new RightCommand();
                case "REPORT":
                    return new ReportCommand();
                case "PLACE":
                    // split the parameters
                    string[] cmdParams = commandargs[1].Split(',');
                    // extract position from parameters
                    Position position = new Position(int.Parse(cmdParams[0]), int.Parse(cmdParams[1]), (Direction)Enum.Parse(typeof(Direction), cmdParams[2], true));
                    return new PlaceCommand(position);

                default:
                    throw new CommandNotFoundException("Command not found for string " + cmd );
            }
        }
    }
}
