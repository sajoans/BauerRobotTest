using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{
    public class PlaceCommand:ICommand
    {
        public string Name
        {
            get { return "Place"; }
        }

        Position newPosition;


        public  PlaceCommand(Position nPosition)
        {
            newPosition = nPosition;
        }

        /// <summary>
        /// Update the robots position with the new position
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public bool Run(IRobot robot)
        {
            robot.Position = newPosition;
            return true;
        }

        /// <summary>
        ///  Simulate the target position without changing the robots position
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public Position Simulate(IRobot robot)
        {
            return newPosition;
        }
    }
}
