using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Commands
{
    public class MoveCommand:ICommand
    {
        public string Name
        {
            get { return "Move"; }
        }


        /// <summary>
        /// Execute the command on the robot 
        /// update robot position with the simulated position
        /// </summary>
        /// <param name="robot"></param>
        /// <returns></returns>
        public bool Run(IRobot robot)
        {
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
            Position targetPosition = new Position(robot.Position.X,robot.Position.Y,robot.Position.Facing);
            switch (targetPosition.Facing)
            {
                case Direction.North:
                    targetPosition.Y++;
                    break;
                case Direction.East:
                    targetPosition.X++;
                    break;
                case Direction.West:
                    targetPosition.X--;
                    break;
                case Direction.South:
                default:
                    targetPosition.Y--;
                    break;
            }
            return targetPosition;
            
        }

      
    }
}
