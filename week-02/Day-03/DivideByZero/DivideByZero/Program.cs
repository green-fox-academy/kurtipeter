using System;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // It should print "fail" if the parameter is 0
            Console.WriteLine(TenDivider(3));
            Console.WriteLine(TenDivider(0));
            Console.ReadLine();

        }

        public static string TenDivider(int inputNum)
        {
            if (inputNum == 0)
            {
                return "fail";
            }
            else
            {
                double solution = 10.0 / inputNum;
                return solution.ToString();
            }
        }
    }
}
