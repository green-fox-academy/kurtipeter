
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            int userInputOne;
            Console.WriteLine("What is your first number?");
            userInputOne = Int32.Parse(Console.ReadLine());

            int userInputTwo;
            Console.WriteLine("What is your second number?");
            userInputTwo = Int32.Parse(Console.ReadLine());

            if (userInputOne > userInputTwo)
            {
                Console.WriteLine(userInputOne);
            }
            else
            {
                Console.WriteLine(userInputTwo);
            }
            Console.ReadLine();
        }
    }
}