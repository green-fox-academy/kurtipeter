using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F35 : Aircraft
    {
        public F35()
        {
            maxAmmo = 12;
            currentAmmo = 0;
            baseDamage = 50;
        }
    }
}
