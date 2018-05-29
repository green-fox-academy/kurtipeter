using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class F16 : Aircraft
    {
        public F16()
        {
           maxAmmo = 8;
           currentAmmo = 0;
           baseDamage = 30;
        }
    }
}
