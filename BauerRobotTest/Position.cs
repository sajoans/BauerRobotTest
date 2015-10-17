using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest
{
    public class Position:IEquatable<Position>
    {
        public int X;
        public int Y;

        public Direction Facing;


        public Position(int x, int y, Direction direction)
        {
            X = x;
            Y = y;
            Facing = direction;
        }

        public bool Equals(Position other)
        {
            if (X == other.X && Y == other.Y && Facing == other.Facing)
                return true;
            return false;
        }
    }
}
