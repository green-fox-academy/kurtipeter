using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            int firstNumber = 0;
            int secondNumber = 0;
            int length = secondNumber - firstNumber;

            while (length <= 0)
            {
                Console.WriteLine("Your second number should be bigger than the first");

                Console.WriteLine("What is your first number:");
                firstNumber = Int32.Parse(Console.ReadLine());

                Console.WriteLine("What is your second number:");
                secondNumber = Int32.Parse(Console.ReadLine());

                length = secondNumber - firstNumber;
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(firstNumber + i);
            }

            Console.ReadLine();
        }
    }
}