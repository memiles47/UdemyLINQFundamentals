using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFirstApplication
{
    class Program
    {
        static void Main()
        {
            var numbers = new List<int>() {15, 64, 747, 65, 14};

            var result = from number in numbers
                         where number < 50
                select number;

            foreach (var item in result)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }
}
