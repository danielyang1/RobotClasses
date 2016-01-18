using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotClasses
{
    class program
    {
        static void Main(string[] args)
        {
            head robotHead = new head();
            robotHead.eyeScan();
            Console.ReadKey();
        }
    }
}
