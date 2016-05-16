using System;

namespace ExtensionMethod
{
    class Program
    {
        static void Main()
        {
            const string s = "Now I'm 53 years old.";

            Console.WriteLine($"The number of digits in the string; {s.CalculateDigits()}");
            Console.ReadKey();
        }
    }
}
