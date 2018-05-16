using System;
using System.Collections.Generic;

namespace Palindrome_searcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "baabnanan";
            Console.ReadLine();
        }

        public static List<string> PalindromeSearcher(string inputString)
        {

            List<int> palindromeIndexes = new List<int>();

            for (int i = 1; i < inputString.Length; i++)
            {
                if (inputString[i] == inputString[i + 1])
                {

                }
            }
         
        }
    }
}
