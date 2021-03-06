﻿using System;
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
            Body wings = new Body();
            Arm leftArm = new Arm(75);
            Arm rocketArm = new Arm(100);
            SlowWingsBody whiteWings = new SlowWingsBody();
            Leg nikes = new Leg();
            weapons littleGuns = new weapons();
            gatling spray = new gatling();
            cannon boomCanon = new cannon();

            robotHead.eyeScan();
            wings.fly();
            leftArm.showWeight();
            rocketArm.punch();
            whiteWings.fly();
            nikes.run();
            littleGuns.shoot();
            spray.shoot();
            boomCanon.shoot();
            Console.ReadKey();
        }
    }   
}
