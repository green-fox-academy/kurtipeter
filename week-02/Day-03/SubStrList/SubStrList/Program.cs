using System;
using System.Text;
using System.Collections.Generic;

namespace SubStrList
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a string and a list of string as a parameter
            //  Returns the index of the string in the list where the first string is part of
            //  Only need to find the first occurence and return the index of that
            //  Returns `-1` if the string is not part any of the strings in the list

            //  Example
            string[] searchArr = { "this", "is", "what", "I'm", "searching", "in", "not" };

            Console.WriteLine(SubStringInList("ching", searchArr));
            //  should print: `4`
            Console.WriteLine(SubStringInList("not", searchArr));
            //  should print: `-1` 
            Console.WriteLine(SubStringInList("sdfsfg", searchArr));
            Console.ReadLine();
        }

        public static string SubStringInList(string subStringToFind, string[] inputStringList)
        {
            string solution = "";

            for (int i = 0; i < inputStringList.Length; i++)
            {
                if (inputStringList[i].IndexOf(subStringToFind) >= 0)
                {
                    solution += "\'" + i.ToString() + "\'";
                }
            }

            if (solution.Length < 1)
            {
                return "\'-1\'";
            }
            else
            {
                return solution;
            }
        }
    }
}
