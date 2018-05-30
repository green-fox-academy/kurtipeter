using System;
using System.Collections.Generic;
using System.Text;

namespace StringedInstruments
{
    class Violin : StringedInstrument
    {
        public Violin()
        {
            numberOfStrings = 4;
            name = "Violin";
        }

        public override string Sound()
        {
            return "Screech";
        }

        public override void Play()
        {
            Console.WriteLine(string.Format("{0}, a {1}-stringed instrument that {2}", name, numberOfStrings, Sound()));
        }
    }
}
