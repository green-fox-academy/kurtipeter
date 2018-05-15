using System;
using System.Collections.Generic;
using System.Text;

namespace AppendLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var far = new List<string> { "kuty", "macsk", "kacs", "rók", "halacsk" };
            // Create a method called AppendA() that adds "a" to every string in the far list.
            // The parameter should be a list.

            Console.WriteLine(AppendA(far));
            // Expected output: "kutya", "macska", "kacsa", "róka", "halacska"
            Console.ReadLine();
        }
        /*
        public static string AppendA(List<string> inputList)
        {
            for (int i = 0; i < inputList.Count; i++)
            {
                inputList[i] += "a";
            }

            string solution = "";

            foreach (string item in inputList)
            {
                solution += item.ToString() + " ";
            }

            return solution;
        }
        */
        public static StringBuilder AppendA(List<string> inputList)
        {
            StringBuilder solution = new StringBuilder();

            for (int i = 0; i < inputList.Count; i++)
            {
                solution.Append($"\"{inputList[i]}a\", ");
            }

            solution.Remove(solution.Length - 2, 2);

            return solution;
        }



    }
}
