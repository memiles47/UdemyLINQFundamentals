using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAggregate
{
    internal class Program
    {
        private static void Main()
        {
            var numbers = new List<int> {15, 65, 41, 23, 74};

            var countOfNumbers = numbers.Count;
            var countOfOddNumbers = numbers.Count(n => n%2 == 1);
            var oddNumbers = numbers.Where(o => o%2 == 1);
            var sumOfOddNumbers = numbers.Where(n => n%2 == 1).Sum();
            var minOddNumbers = numbers.Where(n => n%2 == 1).Min();
            var maxOddNumbers = numbers.Where(n => n%2 == 1).Max();
            var avgOddNumbers = numbers.Where(n => n%2 == 1).Average();

            Console.WriteLine($"Count of items in list \'numbers\': {countOfNumbers}");
            Console.WriteLine($"Count of Odd Number is list \'numbers\': {countOfOddNumbers}");
            Console.WriteLine($"Sum of odd numbers is: {sumOfOddNumbers}");
            Console.WriteLine($"Maximum Odd Number: {maxOddNumbers}, Minumum Odd Number: {minOddNumbers}");
            Console.WriteLine($"Average of the Odd Numbers is: {avgOddNumbers}");

            foreach (var number in oddNumbers)
            {
                Console.WriteLine($"List number: {number}");
            }

            Console.ReadLine();
        }
    }
}
