using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int averageCodingHours = 6;
            int semesterWeeks = 17;
            double firstAnswer = averageCodingHours * 5 * semesterWeeks;
            double secondAnswer = (firstAnswer / (semesterWeeks * 52)) * 100;
            Console.WriteLine(firstAnswer);
            Console.WriteLine(secondAnswer + "%");
            Console.ReadLine();
        }
    }
}