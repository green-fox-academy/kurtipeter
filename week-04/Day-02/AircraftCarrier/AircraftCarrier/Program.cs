using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier redCarrier = new Carrier(300, 1000);
            F16 redF16_1 = new F16();
            F16 redF16_2 = new F16();
            F35 redF35_1 = new F35();
            F35 redF35_2 = new F35();

            Carrier blueCarrier = new Carrier(300, 1000);
            F16 blueF16_1 = new F16();
            F16 blueF16_2 = new F16();
            F35 blueF35_1 = new F35();
            F35 blueF35_2 = new F35();

            redCarrier.FillAllAircraft();

            Console.ReadLine();
        }
    }
}
