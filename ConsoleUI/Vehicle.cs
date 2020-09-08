using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int Year { get; set; } = 2;
        public string Make { get; set; } = "Any Make";
        public string Model { get; set; } = "Any Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine("Yes, this drives");
        }
        

        

    }
}
