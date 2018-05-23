using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal zebraallat = new Animal();
            Console.WriteLine(zebraallat.hunger + " " + zebraallat.thirst);
            zebraallat.Eat();
            zebraallat.Drink();
            Console.WriteLine(zebraallat.hunger + " " + zebraallat.thirst);
            zebraallat.Play();
            Console.WriteLine(zebraallat.hunger + " " + zebraallat.thirst);
            Console.ReadLine();
        }
    }
}
