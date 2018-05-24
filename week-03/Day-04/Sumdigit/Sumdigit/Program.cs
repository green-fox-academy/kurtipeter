using System;

namespace Sumdigit
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a non-negative int n, return the sum of its digits recursively (no loops). 
            // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
            // divide (/) by 10 removes the rightmost digit (126 / 10 is 12). 
            Console.WriteLine(SumDigit(555));
            Console.ReadLine();
        }

        public static int SumDigit(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            int actualDigit  = n % 10;

            return actualDigit + SumDigit(n/10);

        }
    }
}
