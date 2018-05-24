using System;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {

            // Given base and n that are both 1 or more, compute recursively (no loops)
            // the value of base to the n power, so powerN(3, 2) is 9 (3 squared).
            Console.WriteLine(PowerOfN(2,5));
            Console.ReadLine();
        }

        public static int PowerOfN(int baseNum, int powerNum)
        {
            if (powerNum == 0)
            {
                return powerNum = 1;
            }
            else
            {
                return PowerOfN(baseNum, powerNum - 1) * baseNum;
            }
        }
    }
}
