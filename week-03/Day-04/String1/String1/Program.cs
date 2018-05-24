using System;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            Console.WriteLine(TheXChanger("pussx"));
            Console.ReadLine();
        }

        public static string TheXChanger(string input)
        {
            if (input == "")
            {
                return null;
            }

            else
            {
                char firstLetter;

                if (input[0] == 'x')
                {
                    firstLetter = 'y';
                }

                else
                {
                    firstLetter = input[0];
                }

                return firstLetter + TheXChanger(input.Remove(0, 1));
            }
        }
    }
}
