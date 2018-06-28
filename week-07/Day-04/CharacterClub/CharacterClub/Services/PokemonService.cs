using CharacterClub.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterClub.Services
{
    public class PokemonService : AbsGenreService
    {
        public PokemonService()
        {
            imgSources = new List<string> { "kep1", "kep2" };
            characterList = new List<AbsGenreCharacter>();
        }

        public override void CreateChar(string name, string imgSource)
        {
            Pokemon pokemon = new Pokemon { Name = name, imgSource = imgSource};
            characterList.Add(pokemon);
        }
    }
}
