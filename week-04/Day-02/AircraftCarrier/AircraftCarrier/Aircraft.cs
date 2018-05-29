using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Aircraft
    {
        protected int maxAmmo;
        protected int currentAmmo;
        protected int baseDamage;

        public int GetcurrentAmmo
        {
            get
            {
                return currentAmmo;
            }
            set
            {
                currentAmmo = value;
            }
        }

        public int GetmaxAmmo
        {
            get
            {
                return maxAmmo;
            }
        }

        public int Figth() 
        {
            int damage = currentAmmo * baseDamage;
            currentAmmo = 0;
            return damage;
        }

        public void Refill(Carrier carrier)
        {
            if (carrier.GetSetStoredAmmo > maxAmmo)
            {
                currentAmmo += maxAmmo - currentAmmo;
                carrier.GetSetStoredAmmo -= currentAmmo; 
            }
            else
            {
                currentAmmo += carrier.GetSetStoredAmmo;
                carrier.GetSetStoredAmmo -= currentAmmo;
            }
        }

    }
}
