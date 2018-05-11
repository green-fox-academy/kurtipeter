using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double a = 12.23;
            double b = 5.456;
            double c = 17.2324;
            double surface = 2 * a * c + 2 * a * b + 2 * b * c;
            double volume = a * b * c;
            Console.WriteLine("Surface Area: " + surface);
            Console.WriteLine("Volume: " + volume);
            Console.ReadLine();
        }
    }
}