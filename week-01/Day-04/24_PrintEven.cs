using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that prints all the even numbers between 0 and 500
            int numberOfEvens = 0;

            for (int i = 0; i < 500; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    numberOfEvens ++;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("The number of even numbers: " + numberOfEvens);
            Console.ReadLine();
        }
    }
}