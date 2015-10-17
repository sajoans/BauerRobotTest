using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauerRobotTest.Commands;

namespace BauerRobotTest.CommandParsers
{
    public class StringCommandParser:ICommandParser
    {


        public IEnumerable<ICommand> Parse(string commandString,CommandFactory factory)
        {
            List<ICommand> commandList = new List<ICommand>();
            string[] commandLines = commandString.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            foreach (string commandline in commandLines)
            {
                commandList.Add(factory.create(commandline));
            }
            return commandList;
        }
    }
}
