using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize = 0;
            Console.WriteLine("What should be the size of the square?");
            squareSize = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < squareSize; i++)
            {
                for (int j = 0; j < squareSize; j++)
                {
                    if ((i == 0) || (j == 0))
                    {
                        Console.Write("%");
                    }
                    else if ((i == squareSize - 1) || (j == squareSize -1))
                    {
                        Console.Write("%");
                    }
                    else if (i == j)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}