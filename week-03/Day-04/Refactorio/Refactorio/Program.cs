using System;

namespace Refactorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a recursive function called `refactorio`
            // that returns it's input's factorial
            Console.WriteLine(Factorer(4));
            Console.ReadLine();
        }

        public static int Factorer(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return Factorer(n - 1) * n;
        }
    }
}
