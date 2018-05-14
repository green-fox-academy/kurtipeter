using System;

namespace SunElements
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create an array variable named `r`
            //   with the following content: `[54, 23, 66, 12]`
            // - Print the sum of the second and the third element

            int[] r = new int[] { 54, 23, 66, 12 };
            int sum = r[1] + r[2];

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
