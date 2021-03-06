﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AircraftCarrier
{
    class Carrier
    {
        private List<Aircraft> storedAircrafts = new List<Aircraft>();
        private int storedAmmo;
        private int carrierHealth;
        private string name;

        public Carrier(int ammo, int health, string name)
        {
            this.storedAmmo = ammo;
            this.carrierHealth = health;
            this.name = name;
        }

        public int GetSetcarrierHealth
        {
            get
            {
                return carrierHealth;
            }
            set
            {
                carrierHealth = value;
            }
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

        public void GetDamage(int damage)
        {
            carrierHealth = carrierHealth - damage;
        }

        public void AddAircraft(Aircraft aircraft)
        {
            storedAircrafts.Add(aircraft);
        }

        public List<Aircraft> SortAircrafts(List<Aircraft> unsortedAircrafts)
        {
            List<Aircraft> sortedAircrafts = new List<Aircraft>();

            foreach (Aircraft aircraft in unsortedAircrafts)
            {
                if (aircraft.GetTypeOfClass() == "F35")
                {
                    sortedAircrafts.Add(aircraft);
                }
            }

            foreach (Aircraft aircraft in unsortedAircrafts)
            {
                if (aircraft.GetTypeOfClass() == "F16")
                {
                    sortedAircrafts.Add(aircraft);
                }
            }
            return sortedAircrafts;
        }

        public void FillAllAircraft()
        {
            foreach (Aircraft aircraft in SortAircrafts(storedAircrafts))
            {
                storedAmmo -= aircraft.Refill(storedAmmo);
            }
        }

        public int TotalDamage()
        {
            int totalDamage = 0;
            foreach (Aircraft aircraft in storedAircrafts)
            {
                totalDamage += aircraft.Figth();
            }
            return totalDamage;
        }

        public int TotalDamageCapacity()
        {
            int totalDamage = 0;
            foreach (Aircraft aircraft in storedAircrafts)
            {
                totalDamage += aircraft.DamageCapacity();
            }
            return totalDamage;
        }

        public string FigthtWithAllAircraft(Carrier carrier)
        {
            carrier.GetSetcarrierHealth -= TotalDamage();
            if (carrier.GetSetcarrierHealth <= 0)
            {
                return "It's dead Jim :(";
            }
            return "still alive... probably we should refill the ammo before the next attack";
        }

        public string GetStatus()
        {
            string output = string.Format("Name: {0}\nHP: {1}, Aircraft count: {2}, Ammo Storage: {3}, Total damage: {4} \nAircrafts: \n"
            ,name, carrierHealth, storedAircrafts.Count, storedAmmo,TotalDamageCapacity());

            foreach (Aircraft aircraft in storedAircrafts)
            {
                output += string.Format("Type: {0}, Ammo: {1}, Base Damage: {2}, All Damage: {3}"
                    , aircraft.GetTypeOfClass(),aircraft.GetcurrentAmmo,aircraft.GetbaseDamage, aircraft.DamageCapacity() + "\n");
            }
            return output;
        }
    }
}
