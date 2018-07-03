using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterClub.Characters
{
    public class AttackMoves
    {
        public string Name { get; set; }
        public string AttackType { get; set; }
        public int Power { get; set; }

        public override string ToString()
        {
            string output = string.Format("Name: {0}, Type: {1}. Power: {2}", Name, AttackType, Power);
            return output;
        }
    }
}
