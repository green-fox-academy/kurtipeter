using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for a number and prints the multiplication table with that number
            //
            // Example:
            // The number 15 should print:
            //
            // 1 * 15 = 15
            // 2 * 15 = 30
            // 3 * 15 = 45
            // 4 * 15 = 60
            // 5 * 15 = 75
            // 6 * 15 = 90
            // 7 * 15 = 105
            // 8 * 15 = 120
            // 9 * 15 = 135
            // 10 * 15 = 150
            int inputNumber = 0;

            Console.WriteLine("Please give me a number:");
            inputNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("the multiplication table with that number:");
            for (int i = 1; i < 11; i++)
            {
                int multipication = i * inputNumber;
                Console.WriteLine(multipication);
            }
            Console.ReadLine();
        }
    }
}