using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauerRobotTest.Commands;
using BauerRobotTest.CommandParsers;
using BauerRobotTest.Surfaces;

namespace BauerRobotTest
{
    public class CommandCenter
    {

        private IRobot _robot;
        private ISurface Surface;
        private List<ICommand> _commandList;
        private ICommandParser _commandParser;
        private CommandFactory _commandFactory;
        private List<ICommand> _executedCommands;


        public CommandCenter(ICommandParser commandParser, IRobot robot, ISurface surface, CommandFactory commandFactory)
        {
            _robot = robot;
            _commandParser = commandParser;
            Surface = surface;
            _commandFactory = commandFactory;
            _executedCommands = new List<ICommand>();
        }

        public void Execute(string commands)
        {

            _commandList = _commandParser.Parse(commands, _commandFactory).ToList();

            foreach (ICommand command in _commandList)
            {
                // Simulate first and check target position
                Position pos = command.Simulate(_robot);
                if (pos != null && Surface.IsValidPosition(pos))
                {
                    // Run command only if simulated target position is valid point on surface
                    command.Run(_robot);
                    // Add command to executed commands
                    _executedCommands.Add(command);
                }
            }


        }

        public IRobot Robot
        {
            get { return _robot; }
        }

        public List<ICommand> ExecutedCommands
        {
            get { return _executedCommands; }
        }



    }
}
