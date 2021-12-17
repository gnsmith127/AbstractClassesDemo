using System;
namespace ConsoleUI
{
    class Motorcyle : Vehicle
    {
     

        public override string Make { get; set; }
        public override string Model { get; set; }
        public override int Year { get ; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm riding my motorcycle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} that is a {GetType().BaseType.Name} is in virtual drive.");
        }

        public bool HasHandlebars { get; set; }
        public string EngineNoise { get; set; }
    }
}
