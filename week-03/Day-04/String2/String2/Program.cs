using System;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.
            Console.WriteLine(TheXRemover2("xpxexnxixsx"));
            Console.ReadLine();
        }

        public static string TheXRemover2(string input)
        {
            if (input == "")
            {
                return null;
            }

            else
            {
                if (input[0] == 'x')
                {
                    return TheXRemover2(input.Remove(0, 1));
                }

                return input[0] + TheXRemover2(input.Remove(0, 1));
            }
        }
    }
}
