using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            Console.WriteLine("a is {0} and b is {1}", a, b);
            int c = b;
            b = a;
            a = c;
            Console.WriteLine("a is {0} and b is {1}", a, b);
            Console.ReadLine();
        }
    }
}