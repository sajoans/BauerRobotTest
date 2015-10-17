using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{
    public class LeftCommand:ICommand
    {
        public string Name
        {
            get { return "Left"; }
        }


        /// <summary>
        /// Execute the command on the robot 
        /// update robot position with the simulated position
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public bool Run(IRobot robot)
        {
            // Has robot been positioned?
            if (robot.Position == null)
                return false;
            robot.Position = Simulate(robot);
            return true;
        }

        /// <summary>
        ///  Simulate the target position without changing the robots position
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public Position Simulate(IRobot robot)
        {           
            if (robot.Position == null)
                return null;
            int direction = (int)robot.Position.Facing;
            if (--direction < 0)
                direction = 3;
            return new Position(robot.Position.X, robot.Position.Y, (Direction)direction);
        }

    
    }
}
