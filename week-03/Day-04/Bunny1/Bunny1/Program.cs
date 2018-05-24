using System;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have a number of bunnies and each bunny has two big floppy ears.
            // We want to compute the total number of ears across all the bunnies recursively (without loops or multiplication).
            Console.WriteLine(BunnyEarCounter(12));
            Console.ReadLine();
        }

        public static int BunnyEarCounter(int numberOfBunnies)
        {
            if (numberOfBunnies == 1)
            {
                return 2;
            }
            else
            {
                return BunnyEarCounter(numberOfBunnies - 1) + 2;
            }
        }

    }
}
