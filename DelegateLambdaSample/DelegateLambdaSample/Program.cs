using System;

namespace DelegateLambdaSample
{
    internal class Program
    {
        //delegate int MyDelegate(int x, int y);
        public static Func<int, int, int> MyDelegate;

        static void Main()
        {
            //MyDelegate _delegate = (x, y) => x + y;
            //var a = _delegate(5, 10);

            MyDelegate = (x, y) => x + y;
            var a = MyDelegate(10, 50);

            Console.WriteLine($"The value of \'a\' is: {a}");
            Console.ReadKey();
        }

        //static int MyMethod(int a, int b)
        //{
        //    return a + b;
        //}
    }
}
