using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{
    public interface ICommand
    {

         string Name { get; }

         bool Run(IRobot robot);

         Position Simulate(IRobot robot);
    }
}
