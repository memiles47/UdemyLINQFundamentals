using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFiltering
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int> {15, 24, 40, 32, 55};
            var evenNumbers = numbers.Where(n => n % 2 == 0);
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();

        }
    }
}
