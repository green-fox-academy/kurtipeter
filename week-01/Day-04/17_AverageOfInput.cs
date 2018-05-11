using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int numberOne;
            int numberTwo;
            int numberThree;
            int numberFour;
            int numberFive;

            Console.WriteLine("What's you first number infidel");
            numberOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What's you second number infidel");
            numberTwo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What's you third number infidel");
            numberThree = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What's you fourth number infidel");
            numberFour = Int32.Parse(Console.ReadLine());

            Console.WriteLine("What's you fifth number infidel");
            numberFive = Int32.Parse(Console.ReadLine());

            int sum = numberOne + numberTwo + numberThree + numberFour + numberFive;
            int average = sum / 5;

            Console.WriteLine("The sum of your numbers is: " + sum);
            Console.WriteLine("The average of your numbers is: " + average);

            Console.WriteLine("Press ENTER to exit.");
            Console.ReadLine();
        }
    }
}