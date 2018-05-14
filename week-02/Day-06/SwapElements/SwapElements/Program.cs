using System;

namespace SwapElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`

            string[] abc = { "first", "second", "third", "fourth", "fifth" };

            Swap(abc, 0, 2);

            foreach (string item in abc)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            Swap(abc, 1, 4);

            foreach (string item in abc)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static string[] Swap(string[] Array, int elementIndex1, int elementIndex2) 
        {
            string temporary = "";
            temporary = Array[elementIndex1];
            Array[elementIndex1] = Array[elementIndex2];
            Array[elementIndex2] = temporary;
            return Array;
        }
    }
}
