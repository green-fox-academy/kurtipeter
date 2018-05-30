using System;

namespace AircraftCarrier
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrier redCarrier = new Carrier(300, 1000, "The magnificent RedCarrier destroyer of worlds.");
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

            Carrier blueCarrier = new Carrier(200, 500, "Some green boy, ready to be destroyed");
            Carrier greenCarrier = new Carrier(200, 2000, "This one is thougher");

            Console.WriteLine();

            redCarrier.FillAllAircraft();


            Console.WriteLine(redCarrier.GetStatus());
            Console.WriteLine();
            Console.WriteLine(blueCarrier.GetStatus());
            Console.WriteLine();
            Console.WriteLine(redCarrier.FigthtWithAllAircraft(blueCarrier));
            Console.WriteLine(blueCarrier.GetSetcarrierHealth);
            Console.WriteLine();
            redCarrier.FillAllAircraft();
            Console.WriteLine(greenCarrier.GetStatus());
            Console.WriteLine();
            Console.WriteLine(redCarrier.FigthtWithAllAircraft(greenCarrier));
            Console.WriteLine(greenCarrier.GetSetcarrierHealth);
            
            Console.ReadLine();
        }
    }
}
