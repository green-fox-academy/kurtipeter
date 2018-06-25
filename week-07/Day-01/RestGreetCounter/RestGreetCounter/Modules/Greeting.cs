using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestGreetCounter.Modules
{
    public class Greeting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private static int autoID = 1;

        public Greeting()
        {
            Id = autoID;
            autoID++;
        }
    }
}
