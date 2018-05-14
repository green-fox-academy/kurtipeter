using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a function called `factorio`
            //   that returns it's input's factorial
            int givenNumber;

            Console.WriteLine("Please feed me with a number");

            givenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Fractorial(givenNumber));

            Console.ReadLine();
        }

        public static int Fractorial (int number)
        {
            int solution = 1;

            for (int i = 1; i <= number; i++)
            {
                solution *= i;
            };

            return solution;
        }
    }
}
