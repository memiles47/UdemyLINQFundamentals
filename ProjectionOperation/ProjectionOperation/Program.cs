using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectionOperation
{
    internal class Program
    {
        private static void Main()
        {
            var cities = new List<string>()
            {
                "New York",
                "Istanbul",
                "Paris",
                "London",
                "Madrid",
                "Monaco",
                "Owasso",
                "Seattle"
            };

            //var selectedCities = from city in cities
            //    select city;

            var selectedCities = cities.Select((city, index) => new { city, index });

            Console.WriteLine("Cities into collection");
            Console.WriteLine("----------------------");

            //foreach (var i in selectedCities)
            //    Console.WriteLine($"City Name: {i}");
            //Console.ReadKey();

            foreach (var i in selectedCities)
                Console.WriteLine($"City Name: {i.city}\tIndex: {i.index}");
            Console.ReadKey();
        }
    }
}
