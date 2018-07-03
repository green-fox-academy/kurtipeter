using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterClub.Characters
{
    public class Pokemon : AbsGenreCharacter
    {
        public List<AttackMoves> attacks;

        public Pokemon()
        {
            imgSource = "/../img_pokemon/pikachu.png";
            attacks = new List<AttackMoves>();
        }
    }
}
