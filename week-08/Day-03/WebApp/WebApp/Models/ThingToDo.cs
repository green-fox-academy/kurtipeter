using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ThingToDo
    {
        public static int IdCounter = 0;

        public int Id { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }

        public ThingToDo()
        {
            Id = IdCounter;
            IdCounter++;
        }
    }
}
