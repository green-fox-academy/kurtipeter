using System;

namespace Sharpie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sharpie sharpie = new Sharpie("green", 34.23f);
            sharpie.Use();
            Console.WriteLine(sharpie.color + " " +  sharpie.inkAmount +" "+ sharpie.width);
            Console.ReadLine();
        }
    }
}
