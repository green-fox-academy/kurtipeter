using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input,
            // Then prints "Odd" if the number is odd, or "Even" if it is even.
            int userInput;
            Console.WriteLine("What is your number?");
            userInput = Int32.Parse(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                Console.WriteLine("Your number is even!");
            }
            else
            {
                Console.WriteLine("Your number is not even even");
            }
            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}