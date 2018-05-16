using System;

namespace Unique
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a function that takes a list of numbers as a parameter
            //  Returns a list of numbers where every number in the list occurs only once
            //  Example
            //  Console.WriteLine(Unique({ 1, 11, 34, 11, 52, 61, 1, 34}));
            //  should print: `[1, 11, 34, 52, 61]`
            int[] normalArray = { 1, 11, 34, 11, 52, 61, 1, 34, 52, 99 };

            normalArray = Unique(normalArray);

            foreach (int item in normalArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }

        public static int[] Unique(int[] array)
        {

            int[] temporaryArray = new int[array.Length];

            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int counter1 = 0;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] != temporaryArray[j])
                    {
                        counter1++;
                    }
                }

                if (counter1 == array.Length)
                {
                    temporaryArray[index] = array[i];
                    index++;
                }
            }

            return temporaryArray;
        }
    }
}
