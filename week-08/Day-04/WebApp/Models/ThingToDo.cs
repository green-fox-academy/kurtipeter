﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class ThingToDo
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public bool IsDone { get; set; }
    }
}
