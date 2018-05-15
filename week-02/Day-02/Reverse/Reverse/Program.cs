using System;
using System.Text;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";

            // Create a method that can reverse a String, which is passed as the parameter
            // Use it on this reversed string to check it!

            Console.WriteLine(Reverser(reversed));
            Console.ReadLine();
        }

        public static string Reverser(string inputString)
        {
            string outputString = "";

            for (int i = inputString.Length-1; i >= 0 ; i--)
            {
                outputString += (inputString[i]);
            }

            return outputString;

        }
    }
}
