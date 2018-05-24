using System;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
            Console.WriteLine(StarInserter("star"));
            Console.ReadLine();
        }

        public static string StarInserter(string input)
        {
            if (input == "")
            {
                return null;
            }

            char startoBe = '*';

            if (input.Length == 1)
            {
                startoBe = '\0';    //not so elegant. bacause something is still at the end of the string even if it is not visible
            }
           
            return input[0].ToString() + startoBe.ToString() + StarInserter(input.Remove(0, 1));
        }
    }
}
