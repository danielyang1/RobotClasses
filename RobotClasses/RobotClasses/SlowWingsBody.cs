using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class slowWingsBody
    {
        string skin = "carbon fiber";
        string back = "white feathery wings";

        public override void fly()
        {
            Console.WriteLine("Fly slower but over lighter weight and less fuel!");
        }
    }
}
