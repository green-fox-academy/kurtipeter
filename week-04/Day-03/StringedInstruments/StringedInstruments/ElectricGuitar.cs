using System;
using System.Collections.Generic;
using System.Text;

namespace StringedInstruments
{
    class ElectricGuitar : StringedInstrument
    {
        public ElectricGuitar()
        {
            numberOfStrings = 6;
            name = "Electric Guitar";
        }

        public ElectricGuitar(int inputStrings)
        {
            numberOfStrings = inputStrings;
            name = "Electric Guitar";
        }

        public override string Sound()
        {
            return "Twang";
        }

        public override void Play()
        {
            Console.WriteLine(string.Format("{0}, a {1}-stringed instrument that {2}", name, numberOfStrings, Sound()));
        }
    }
}
