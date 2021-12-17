using System;
namespace ConsoleUI
{
    class Car : Vehicle
    {
        public override string Make { get; set; }
        public override string Model { get; set; }
        public override int Year { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine($"This car is in drive.");
        }

       
        public bool HasTrunk { get; set; }
        public int Doors { get; set; }
    }
}
