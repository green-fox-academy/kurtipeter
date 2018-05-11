using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Please provide a reasonable number!");
            int userNumber = 0;
            userNumber = Int32.Parse(Console.ReadLine());
            double changeUserNumberToMile = userNumber * 0.621371192;
            Console.WriteLine("If I assume that your number was in km, then it is " + changeUserNumberToMile + " in mile.");
            Console.ReadLine();
        }
    }
}