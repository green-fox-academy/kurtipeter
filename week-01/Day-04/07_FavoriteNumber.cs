using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int favoriteNumber = 0;
            Console.WriteLine("What is your favorite number?");
            favoriteNumber = Int32.Parse(Console.ReadLine());
            Console.ReadLine();
        }
    }
}