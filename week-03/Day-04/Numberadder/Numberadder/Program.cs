using System;

namespace Numberadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NumberAdder(3));
            Console.ReadLine();
        }

        public static int NumberAdder(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return NumberAdder(n - 1) + n;
            }
        }
    }
}
