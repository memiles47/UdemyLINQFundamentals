﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFiltering
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = new List<int> {15, 24, 40, 32, 55};

            var evenNumbers = numbers.Where((n, i) => (n % 2 == 0) && i > 1);

            foreach (var num in evenNumbers)
                Console.WriteLine(num);
            
            Console.ReadLine();
        }
    }
}
