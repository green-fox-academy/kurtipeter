using System;

namespace IncrementElement
{
    class Program
    {
        static void Main(string[] args)
        {
            //- Create an array variable named `t`
            //  with the following content: `[1, 2, 3, 4, 5]`
            //- Increment the third element
            //- Print the third element
            int[] t = { 1, 2, 3, 4, 5 };

            t[2]++;

            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }

            Console.ReadLine();

        }
    }
}
