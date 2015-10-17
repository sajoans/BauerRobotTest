using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{
    public class CommandNotFoundException:Exception
    {

         public CommandNotFoundException()
        {
        }

         public CommandNotFoundException(string message)
            : base(message)
        {
        }
    }
}
