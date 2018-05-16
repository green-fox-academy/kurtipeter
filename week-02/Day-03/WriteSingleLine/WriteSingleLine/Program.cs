using System;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open a file called "my-file.txt"
            // Write your name in it as a single line
            // If the program is unable to write the file,
            // then it should print an error message like: "Unable to write file: my-file.txt"

            NameWriter();
            string[] check = File.ReadAllLines("my-file.txt");
            Console.WriteLine(check[0]);
            Console.ReadLine();
        }


        public static void NameWriter()
        {

            try
            {
                StreamWriter sw = new StreamWriter("my-file.txt");
                sw.WriteLine("Kurtipeti");
                sw.Dispose();
            }
            catch (Exception)
            {
                Console.WriteLine("Unbale to write in the file");
            }
        }
    }
}
