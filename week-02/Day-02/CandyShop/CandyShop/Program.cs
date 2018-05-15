using System;
using System.Text;
using System.Collections.Generic;

namespace CandyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            // Accidentally we added "2" and "false" to the list.
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines
            // Create a method called Sweets() which takes the list as a parameter.

            Console.WriteLine(Sweets(list));
            Console.ReadLine();
            // Expected output: "Cupcake", "Croissant", "Brownie", "Ice cream"
        }

        public static StringBuilder Sweets(List<object> inputList)
        {

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < inputList.Count; i++)
            {
                if (inputList[i].GetType() == typeof(bool))
                {
                    output.Append("\"Ice cream\", ");
                }
                else if (inputList[i].GetType() == typeof(int))
                {
                    output.Append("\"Croissant\", ");
                }
                else
                {
                    output.Append($"\"{inputList[i]}\", ");
                }
            }

            output.Remove(output.Length - 2, 2);

            return output;
            
        }
    }
}
