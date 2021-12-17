using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - done
             * The vehicle class shall have three string properties Year, Make, and Model - done
             * Set the defaults to something generic in the Vehicle class - ignored
             * Vehicle shall have an abstract method called DriveAbstract with no implementation - done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. - done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - Done
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - Done
             * Provide the implementations for the abstract methods - 
             * Only in the Motorcycle class will you override the virtual drive method - Done
            */

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - Done
             * - new it up as one of each derived class - Done
             * Set the properties with object initializer syntax - Done
             */

            Vehicle car1 = new Car { Make = "MINI", Model = "Cooper", Year = 2020, Doors = 4, HasTrunk = true };
            Car car2 = new Car { Make = "Mazda", Model = "CX-5", Year = 2015, Doors = 4, HasTrunk = true };
            Vehicle motor1 = new Motorcyle { Make = "Harley-Davidson", Model = "Trike", Year = 2019, EngineNoise = "vroom vroom", HasHandlebars = true };
            Motorcyle motor2 = new Motorcyle { Make = "Kawasaki", Model = "Ninja 650", Year = 2021, EngineNoise = "grrrrrrr", HasHandlebars = true };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motor1);
            vehicles.Add(motor2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Make}, {item.Model}, {item.Year}");
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            motor1.DriveAbstract();
            car1.DriveAbstract();

            #endregion            
            Console.ReadLine();
        }
    }
}
