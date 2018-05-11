using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // diamond like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //  *****
            //   ***
            //    *
            //
            // The diamond should have as many lines as the number was
            int rombus = 0;

            do
            {
                Console.WriteLine("Give me your number:");
                rombus = Int32.Parse(Console.ReadLine());

            } while ((rombus < 3) || (rombus % 2 == 0));

            int firstPart = (rombus + 1) / 2;
            int secondPart = (rombus - 1) / 2;

            for (int i = 0; i < firstPart; i++)
            {
                for (int j = firstPart; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < i + i + 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            for (int i = 1; i < secondPart + 1; i++)
            {
                for (int x = 0; x < i + 1; x++)
                {
                    Console.Write(" ");
                }
                for (int j = rombus; j > i + i; j--) 
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

            Console.WriteLine(rombus);
            Console.ReadLine();
        }
    }
}