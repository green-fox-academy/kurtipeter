using System;
using System.Collections.Generic;
using System.Text;

namespace QuoteSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code
            // Create a method called QuoteSwap().

            // Also, print the sentence to the output with spaces in between.
            Console.WriteLine(QuoteSwap(list,2,5));
            Console.ReadLine();
            // Expected output: "What I cannot create I do not understand." 
        }

        public static string QuoteSwap(List<string> input, int indexA, int indexB)
        {
            string tempItem = input[indexA];
            input[indexA] = input[indexB];
            input[indexB] = tempItem;

            string output = "";

            for (int i = 0; i < input.Count; i++)
            {
                output += input[i] + " ";
            }

            output.Remove(output.Length - 1, 1);

            return output;

        }
    }
}
