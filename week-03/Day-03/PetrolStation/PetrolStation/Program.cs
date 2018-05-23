using System;

namespace PetrolStation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Station station1 = new Station();
            Console.WriteLine("Station initial gas: " + station1.gasAmount);

            station1.Refill(car1);
            Console.WriteLine("Filling up the car");

            Console.WriteLine("The car has " + car1.gasAmount + " gas");
            Console.WriteLine("Station after the first refill: " + station1.gasAmount);

            Console.WriteLine("The car is running 50 km");
            car1.CarIsRunning(50);
            Console.WriteLine("The car has " + car1.gasAmount + " gas after 50 km");
            Console.WriteLine("The car has " + car1.capacity + " capacity after 50 km");

            station1.Refill(car1);
            Console.WriteLine("The car has "  + car1.gasAmount +  " gas after refill");
            Console.WriteLine("Station after the second refill: " + station1.gasAmount);



            Console.ReadLine(); 
            ;


        }
    }
}
