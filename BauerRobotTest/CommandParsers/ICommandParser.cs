using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauerRobotTest.Commands;

namespace BauerRobotTest.CommandParsers
{
    public interface ICommandParser
    {
        IEnumerable<ICommand> Parse(string commandString, CommandFactory commandFactory);

    }
}
