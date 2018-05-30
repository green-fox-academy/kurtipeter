using System;
using System.Collections.Generic;
using System.Text;

namespace StringedInstruments
{
    class BassGuitar : StringedInstrument
    {
        public BassGuitar()
        {
            numberOfStrings = 4;
            name = "Bass Guitar";
        }

        public BassGuitar(int inputStrings)
        {
            numberOfStrings = inputStrings;
            name = "Bass Guitar";
        }

        public override string Sound()
        {
            return "Duum-duum-duum";
        }

        public override void Play()
        {
            Console.WriteLine(string.Format("{0}, a {1}-stringed instrument that {2}", name, numberOfStrings, Sound()));
        }
    }
}

