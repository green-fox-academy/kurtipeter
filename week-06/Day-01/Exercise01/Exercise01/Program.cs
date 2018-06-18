using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> test = from num in n
                                    where num % 2 == 0
                                    select num;

            foreach (int item in test)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            IEnumerable<int> test2 = n.Where(x => x % 2 == 0);

            foreach (int item in test2)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
