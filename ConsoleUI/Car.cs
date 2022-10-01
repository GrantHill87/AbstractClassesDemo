using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle //car is the derived class, and vehicle is the base class.
    {
        public Car()
        {

        }
        public bool HasTrunk { get; set; } = true; //this never printed to the console as intended, when called in the main script (program.cs). It also doesn't override the same
        // property from the base class.

        public override void DriveAbstract()
        {
            Console.WriteLine("This car is in drive."); //this script doesn't call for a method to be used to assist with the written description of the car being in drive (no $ sign).
        }
    }
}
