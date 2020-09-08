using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle drives like a motorcycle");
        }
        public bool HasSideCart { get; set; } = false;

        public override void DriveVirtual()
        {
            Console.WriteLine("This handles like a motorcycle");
        }

    }
}
