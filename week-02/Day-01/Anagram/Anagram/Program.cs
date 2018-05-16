using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWordOfTheUser = "";
            string secondWordOfTheUser = "";

            Console.WriteLine("Give my your first word");
            firstWordOfTheUser = Console.ReadLine();

            Console.WriteLine("Give my your second word");
            secondWordOfTheUser = Console.ReadLine();

            bool answer = Anagram(firstWordOfTheUser, secondWordOfTheUser);

            Console.WriteLine(answer);
            
            Console.ReadLine();
        }

        public static bool Anagram(string word1, string word2)
        {
            string newWord = "";

            for (int i = 0; i < word1.Length; i++)
            {
                int usedLetter = 0;

                for (int j = 0; j < word2.Length; j++)
                {
                    if (word1[i] == word2[j] && usedLetter < 1)
                    {
                        newWord += word1[i];
                        usedLetter++;
                    }
                }
            }

            if (word1 == newWord)
            {
                return true;
            }
            else
            {
                return false;  
            }

        }

    
     
        
    }
}
