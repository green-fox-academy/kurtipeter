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

        public int GetbaseDamage
        {
            get
            {
                return baseDamage;
            }
        }

        public int Figth() 
        {
            int damage = currentAmmo * baseDamage;
            currentAmmo = 0;
            return damage;
        }

        public int DamageCapacity() 
        {
            int damage = currentAmmo * baseDamage;
            return damage;
        }

        public int Refill(int carrierAmmo)
        {
            if (currentAmmo != maxAmmo)
            {
                if (carrierAmmo > maxAmmo)
                {
                    currentAmmo += maxAmmo - currentAmmo;
                    return currentAmmo;
                }
                else
                {
                    currentAmmo += carrierAmmo;
                    return currentAmmo;
                }
            }
            return 0;
        }

        public string GetTypeOfClass()
        {
            return this.GetType().Name;
        }
    }
}
