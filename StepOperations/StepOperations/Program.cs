using System;
using System.Collections.Generic;
using System.Linq;

namespace StepOperations
{
    class Program
    {
        static void Main()
        {
            var vehicles = new List<string> {"Car", "Ship", "Plane", "Car", "Train", "Spaceship", "Train"};

            var uniqueVehicles = vehicles.Distinct().OrderBy(v => v[0]);
            foreach (var vehicle in uniqueVehicles)
            {
                Console.WriteLine($"Item: {vehicle}");
            }

            Console.ReadLine();
        }
    }
}
