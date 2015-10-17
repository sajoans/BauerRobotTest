using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauerRobotTest.Commands;

namespace BauerRobotTest
{
    public class Robot:IRobot
    {

        private Position _position;
        private List<Position> _reportedPositions;


        public Robot()
        {
            _reportedPositions = new List<Position>();
        }

        /// <summary>
        /// Hold the position of the robot
        /// </summary>
        public Position Position
        {
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }

        }

        /// <summary>
        /// Robot's reporting function
        /// </summary>
        public void Report()
        {
            _reportedPositions.Add(Position);

        }

        public List<Position> ReportedPositions
        {
            get { return _reportedPositions; }           
        }

    }
}
