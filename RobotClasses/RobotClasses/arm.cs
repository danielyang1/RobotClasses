using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class arm
    {
        float fingers = 5;
        float weightOfArmInLbs = 25;
        float strength = 8;
        float fist = 1;
        string elbow = "rocket propulsion";

        public void punch()
        {
            Console.WriteLine("Launches fist at target with a strength of {0} ", fist);
        }

    }
}
