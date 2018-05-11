using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The second represents the number of pigs owned by the farmer
            // It should print how many legs all the animals have
            int numberOfChickens;
            int numberOfPigs;

            Console.WriteLine("How many chickens u got?");
            numberOfChickens = Int32.Parse(Console.ReadLine());

            Console.WriteLine("How many pigs u got?");
            numberOfPigs = Int32.Parse(Console.ReadLine());

            int legsOfTheAnimals = numberOfChickens * 2 + numberOfPigs * 4;
            
            Console.WriteLine("The full amount of animal legs you posses: " + legsOfTheAnimals);
            Console.ReadLine();
        }
    }
}