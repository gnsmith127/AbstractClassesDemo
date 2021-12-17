using System;
namespace ConsoleUI
{
    abstract class Vehicle
    { 

        public abstract string Make { get; set; }
        public abstract string Model { get; set; }
        public abstract int Year { get; set; }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in virtual drive.");
        }
    }
}
