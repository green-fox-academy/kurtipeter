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
            F16 redF16_2 = new F16();
            F35 redF35_2 = new F35();
            redCarrier.AddAircraft(redF16_1);
            redCarrier.AddAircraft(redF35_1);
            redCarrier.AddAircraft(redF16_2);
            redCarrier.AddAircraft(redF35_2);

            redCarrier.FillAllAircraft();
            redCarrier.FillAllAircraft();
            Console.WriteLine(redCarrier.GetStatus());
            /*
            Carrier blueCarrier = new Carrier(200, 500);
            Carrier greenCarrier = new Carrier(200, 1000);

            Console.WriteLine(redCarrier.GetStatus());
            Console.WriteLine();

            redCarrier.FillAllAircraft();
            Console.WriteLine(redF35_1.GetcurrentAmmo);
            Console.WriteLine(redF16_1.GetcurrentAmmo);
            Console.WriteLine(redCarrier.GetSetStoredAmmo);
            Console.WriteLine();

            Console.WriteLine(redCarrier.GetStatus());
            Console.WriteLine(redCarrier.FigthtWithAllAircraft(blueCarrier));
            Console.WriteLine(blueCarrier.GetSetcarrierHealth);
            redCarrier.FillAllAircraft();
            Console.WriteLine(redCarrier.FigthtWithAllAircraft(greenCarrier));
            */
            Console.ReadLine();
        }
    }
}
