using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was
            int triangle = 0;

            Console.WriteLine("Give me your number:");
            triangle = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < triangle; i++)
            {
                for (int x = triangle; x > i; x--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i + i + 1; j += 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}