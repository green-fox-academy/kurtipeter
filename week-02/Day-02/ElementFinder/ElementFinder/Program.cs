using System;
using System.Collections.Generic;
using System.Text;

namespace ElementFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ContainsSeven(List));
            Console.ReadLine();
            // Write a method that checks if the arrayList contains "7" if it contains return "Hoorray" otherwise return "Noooooo"
            // The output should be: "Noooooo"
            // Do this again with a different solution using different list methods!
        }

       public static string ContainsSeven(List<int> inputList)
        {
            int itHasASeven = 0;
            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i] == 7 && itHasASeven == 0)
                {
                    itHasASeven++;
                    return "Hoorray";
                }
            }
            return "Nooooo";
        }
    }
}
