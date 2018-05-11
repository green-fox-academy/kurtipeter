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
                if ((i == 0) || (i == squareSize - 1))
                {
                    for (int j = 0; j < squareSize; j++)
                    {
                        Console.Write("%");
                    }
                    Console.WriteLine("");
                }
                else
                {
                    for (int x = 0; x < squareSize; x++)
                    {
                        if ((x == 0) || (x == squareSize -1))
                        {
                            Console.Write("%");
                        }
                        else if (x == i)
                        {
                            Console.Write("%");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine(" ");
                }
            }
        }
    }
}