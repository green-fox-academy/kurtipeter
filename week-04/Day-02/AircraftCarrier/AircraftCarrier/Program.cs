using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier redCarrier = new Carrier(300, 1000);
            F16 redF16_1 = new F16();
            F35 redF35_1 = new F35();
            redCarrier.AddAircraft(redF16_1);
            redCarrier.AddAircraft(redF35_1);

            Carrier blueCarrier = new Carrier(300, 1000);
            F16 blueF16_1 = new F16();
            F35 blueF35_1 = new F35();

            Console.WriteLine(redF16_1.GetcurrentAmmo);
            Console.WriteLine(redF35_1.GetcurrentAmmo);
            redCarrier.FillAllAircraft();
            Console.WriteLine(redF35_1.GetcurrentAmmo);
            Console.WriteLine(redF16_1.GetcurrentAmmo);
            Console.WriteLine(redCarrier.GetSetStoredAmmo);

            Console.ReadLine();
        }
    }
}
