using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Station
    {
        public int gasAmount;

        public Station()
        {
            gasAmount = 1000;
        }

        public int Refill(Car car)
        {
            gasAmount -= car.capacity;
            car.gasAmount += car.capacity;
            car.capacity = 0;
            return car.gasAmount;
        }
    }
}
