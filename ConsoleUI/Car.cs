using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("This car drives like a car");
        }
        public bool HasTrunk { get; set; } = true;
    }
}
