using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Surfaces
{
    public class Table:ISurface
    {
        private double _length;
        private double _width;

        public Table(double length, double width)
        {
            _length = length;
            _width = width;
        }

        public bool IsValidPosition(Position position)
        {
            // x is out of perimeter
            if (position.X < 0 || position.X > _width)
                return false;
            // check if y is outside perimeter
            if (position.Y < 0 || position.Y > _length)
                return false;
            // position is inside or on the perimeter
            return true;

        }
    }
}
