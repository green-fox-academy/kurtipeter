using System;
using System.Collections.Generic;

namespace FleetOfThings
{
    public class Fleet
    {
        private List<Thing> Things;

        public Fleet()
        {
            Things = new List<Thing>();
        }

        public void Add(Thing thing)
        {
            Things.Add(thing);
        }

        public string WriteFleetOut()
        {
            string output = "";

            for (int i = 0; i < Things.Count; i++)
            {
                output += (i+1).ToString() + ". [";
                if (Things[i].IsItComplete())
                {
                    output += "X";
                }
                else
                {
                    output += " ";
                }
                output += "] " + Things[i].NameOfTheThing() + "\n";
            }
            return output;
        }
    }
}