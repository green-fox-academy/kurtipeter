using System;
using System.Collections.Generic;
using System.Text;

namespace PetrolStation
{
    class Car
    {
        public int gasAmount;
        public int capacity;

        public Car()
        {
            gasAmount = 0;
            capacity = 100;
        }

        public void CarIsRunning(int distance)
        {
            gasAmount -= distance;
            capacity += distance;
        }
    }
}
