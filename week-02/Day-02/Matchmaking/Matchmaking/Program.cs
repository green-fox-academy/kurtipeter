using System;
using System.Collections.Generic;

namespace Matchmaking
{
    class Program
    {
        static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };

            // Write a method that joins the two lists by matching one girl with one boy into a new list
            // Exepected output: "Eve", "Joe", "Ashley", "Fred"...
            foreach (var item in MakingMatches(girls, boys))
            {
                Console.WriteLine(item);
            }


            Console.ReadLine();
        }
        /*
        public static List<string> MakingMatches(List<string> girls, List<string> boys)
        {
            List<string> matchedPairs = new List<string>();

            int forLoopLength = 0;

            if (girls.Count >= boys.Count)
            {
                forLoopLength = boys.Count;
            }
            else
            {
                forLoopLength = girls.Count;
            }

            for (int i = 0; i < forLoopLength; i++)
            {
                matchedPairs.Add(girls[i]);
                matchedPairs.Add(boys[i]);
            }

            return matchedPairs;
            */
        public static List<string> MakingMatches(List<string> girls, List<string> boys)
        {
            List<string> matchedPairs = new List<string>();

            int i = 0;

            while (girls.Count > i && boys.Count > i)
            {
                matchedPairs.Add(girls[i]);
                matchedPairs.Add(boys[i]);
                i++;
            }

            return matchedPairs;
        }
        
    }
}
