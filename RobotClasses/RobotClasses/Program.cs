using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Head robotHead = new Head();
            Body whiteWings = new Body();
            Arm leftArm = new Arm(75);
            Arm rocketArm = new Arm(100);
            SlowWingsBody wings = new SlowWingsBody();
            Leg nikes = new Leg();
            robotHead.eyeScan();
            whiteWings.fly();
            leftArm.showWeight();
            rocketArm.punch();
            wings.fly();
            nikes.run();
            Console.ReadKey();
        }
    }   
}
