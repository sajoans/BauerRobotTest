using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{
    public class ReportCommand:ICommand
    {
        public string Name
        {
            get { return "Command"; }
        }

        /// <summary>
        /// Execute the robots report function
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public bool Run(IRobot robot)
        {
            if (robot.Position == null)
                return false;
            robot.Report();
            return true;
        }

        /// <summary>
        ///  Simulate the target position without changing the robots position
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public Position Simulate(IRobot robot)
        {
            return robot.Position;           
        }
    }
}
