using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BauerRobotTest.Commands;

namespace BauerRobotTest.CommandParsers
{
    public class XMLCommandParser:ICommandParser
    {
        public IEnumerable<ICommand> Parse(string commandString, CommandFactory commandFactory)
        {
            throw new NotImplementedException();
        }
    }
}
