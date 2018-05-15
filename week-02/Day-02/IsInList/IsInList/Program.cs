using System;
using System.Collections.Generic;

namespace IsInList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            List<int> checkThisNumbers = new List<int> { 4, 8, 12, 16, 17 };

            // Check if list contains all of the following elements: 4,8,12,16
            // Create a method that accepts list as an input
            // it should return "true" if it contains all, otherwise "false"
            Console.WriteLine(CheckNums(list, checkThisNumbers));
            Console.ReadLine();
        }

        public static bool CheckNums(List<int> list, List<int> checkList)
        {
            int counter = 0;

            for (int i = 0; i < checkList.Count; i++)
            {
                if (list.Contains(checkList[i]))
                {
                    counter++;
                }
            }

            if (counter == checkList.Count)
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
