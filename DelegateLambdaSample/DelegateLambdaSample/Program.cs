using System;

namespace DelegateLambdaSample
{
    class Program
    {
        delegate int MyDelegate(int x, int y);

        static void Main()
        {
            MyDelegate _delegate = MyMethod;
            var a = _delegate(5, 10);

            Console.WriteLine($"The value of \'a\' is: {a}");
            Console.ReadKey();

        }

        static int MyMethod(int a, int b)
        {
            return a + b;
        }
    }
}
