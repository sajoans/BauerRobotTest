using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest
{
    public interface IRobot
    {

        Position Position { get; set; }

        void Report();

        List<Position> ReportedPositions { get; }



    }
}
