using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerRobotTest.Surfaces
{
    public interface ISurface
    {
        bool IsValidPosition(Position position);
    }
}
