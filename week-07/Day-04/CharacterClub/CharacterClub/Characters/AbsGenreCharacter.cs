﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterClub.Characters
{
    public abstract class AbsGenreCharacter
    {
        public string Name { get; set; }
        public string Food { get; set; }
        public string Drink { get; set; }
        public string imgSource;
    }
}
