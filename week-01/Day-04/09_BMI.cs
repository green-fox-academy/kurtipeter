using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double massInKg = 81.2;
            double heightInM = 1.78;
            double solution = massInKg / (heightInM * heightInM);
            Console.WriteLine("The Body mass index (BMI) you are looking for: {0}", solution);
            Console.ReadLine();
        }
    }
}