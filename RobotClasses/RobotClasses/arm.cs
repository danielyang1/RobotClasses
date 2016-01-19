using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class Arm
    {
        float fingers = 5;
        public int weightOfArmInLbs;
        float fist = 20;
        public Arm (int armWeight)
        {
            weightOfArmInLbs = armWeight;
        }
        public void showWeight()
        {
            Console.WriteLine("3 - Weight of Arms: {0}", weightOfArmInLbs);
        }
        public void punch()
        {
            Console.WriteLine("4 - Launches fist at target with a strength of {0} ", fist);
        }
    }
}
