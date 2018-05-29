using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Carrier
    {
        private List<Aircraft> storedAircrafts = new List<Aircraft>();
        private int storedAmmo;
        private int carrierHealth;

        public Carrier(int ammo, int health)
        {
            this.storedAmmo = ammo;
            this.carrierHealth = health;
        }

        public int GetSetStoredAmmo
        {
            get
            {
                return storedAmmo;
            }
            set
            {
                storedAmmo = value;
            }
        }

        public void AddAircraft(Aircraft aircraft)
        {
            storedAircrafts.Add(aircraft);
        }

        public void FillAllAircraft()
        {
            foreach (Aircraft aircraft in storedAircrafts)
            {
                if (GetSetStoredAmmo > aircraft.GetmaxAmmo)
                {
                    aircraft.GetcurrentAmmo += aircraft.GetmaxAmmo - aircraft.GetcurrentAmmo;
                    GetSetStoredAmmo -= aircraft.GetcurrentAmmo; 
                }
                else
                {
                    aircraft.GetcurrentAmmo += GetSetStoredAmmo;
                    GetSetStoredAmmo -= aircraft.GetcurrentAmmo;
                }
            }
        }
    }
}
