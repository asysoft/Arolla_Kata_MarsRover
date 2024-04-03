using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service
{
    internal interface IDeplacerRobot
    {
        void Deplacer(char comand, char direction);
    }
}
