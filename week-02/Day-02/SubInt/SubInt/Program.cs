using System;
using System.Collections.Generic;
using System.Text;

namespace SubInt
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a number and a list of numbers as a parameter
            //  Returns the indeces of the numbers in the list where the first number is part of
            //  Returns an empty list if the number is not part any of the numbers in the list

            //  Example:
            Console.WriteLine(SubIntIndexFinderInArrays(1, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: `[0, 1, 4]`
            Console.WriteLine(SubIntIndexFinderInArrays(9, new int[] { 1, 11, 34, 52, 61 }));
            //  should print: '[]'
            Console.ReadLine();
        }

        public static string SubIntIndexFinderInArrays(int inputNum, int[] inputArray)
        {
            string indexContainer = "[";
 
            for (int i = 0; i < inputArray.Length; i++)
            {
                char[] tempContainer = inputArray[i].ToString().ToCharArray();

                int alreadyContainTheNumber = 0;

                foreach (var item in tempContainer)
                {
                    if (Int32.Parse(item.ToString()) == inputNum && alreadyContainTheNumber == 0)
                    {
                        indexContainer += Convert.ToString(i) + ", ";
                        alreadyContainTheNumber++;
                    }
                }
            }
            if (indexContainer.Length > 1)
            {
                indexContainer = indexContainer.Remove(indexContainer.Length - 2, 2);
            }

            indexContainer += "]";
            
            return indexContainer;
        }
    }
}
