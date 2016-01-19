using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class Leg
    {
        int legs = 2;
        int speed = 20;
        public void run()
        {
            Console.WriteLine("6 - Sprint forward: Top speed of: {0}", speed);
        }
    }
}
