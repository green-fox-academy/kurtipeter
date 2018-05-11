using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            int hoursLeft = 24 - currentHours;
            int minutesLeft = 60 - currentMinutes;
            int secondsLeft = 60 - currentSeconds;
            int remainingSecondOfTheDay = hoursLeft * 60 * 60 + minutesLeft * 60 + secondsLeft;
            Console.Write("Remaining seconds:" + remainingSecondOfTheDay);
            Console.ReadLine();
        }
    }
}