using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class SlowWingsBody : Body
    {
        string skin = "carbon fiber";
        string back = "white feathery wings";

        public void fly()
        {
            Console.WriteLine("5 - Fly slower but lighter weight and less fuel!");
        }
    }
}
