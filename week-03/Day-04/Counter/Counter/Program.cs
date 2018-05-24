using System;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Counter(12));
            Console.ReadLine();
        }

        public static int Counter(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return Counter(n - 1);
            }
        }
    }
}
