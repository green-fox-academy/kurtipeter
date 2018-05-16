using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output

            int userNumber = 0;

            Console.WriteLine("Give me your number infidel:");

            userNumber = Int32.Parse(Console.ReadLine());

            int[,] twoDimensionalArray = new int[userNumber,userNumber];

            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        twoDimensionalArray[i, j] = 1;
                    }
                    else
                    {
                        twoDimensionalArray[i, j] = 0;
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("Behold the magic:");
            Console.WriteLine();

            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    Console.Write(twoDimensionalArray[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
