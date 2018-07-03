using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Poker poker = new Poker();

            Console.WriteLine(poker.GetValue("5D"));
            Console.ReadLine();
        }
    }
}
