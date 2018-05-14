using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            int givenNumber;

            Console.WriteLine("Please feed me with a number");

            givenNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine(Sum(givenNumber));
            Console.ReadLine();

        }

        public static int Sum(int number)
        {
            int solution = 0;

            for (int i = 1; i <= number; i++)
            {
                solution += i;
            }

            return solution;

        }
    }
}
