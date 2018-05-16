using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

        	int pyramidHeight = 0;
            Console.WriteLine("What should be the size of the pyramid?");
            pyramidHeight = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < pyramidHeight; i++)
            {
                for (int j = pyramidHeight; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x < i + i + 1; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}