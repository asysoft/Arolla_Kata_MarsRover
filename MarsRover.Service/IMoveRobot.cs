using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service
{
    internal interface IMoveRobot
    {
        void Move(char comand, char direction);
    }
}
