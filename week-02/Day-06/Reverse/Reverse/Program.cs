using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`

            int[] aj = { 3, 4, 5, 6, 7 };

            aj = ArrayReverser(aj);

            foreach (int item in aj)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }

        public static int[] ArrayReverser(int[] array)
        {
            int[] temporaryArray = new int[array.Length];

            int index = 0;

            for (int i = array.Length-1; i >= 0; i--)
            {
                temporaryArray[index] = array[i];
                index++;
            }

            return temporaryArray;
        }
    }
}
