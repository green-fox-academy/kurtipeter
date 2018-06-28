using CharacterClub.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterClub.Services
{
    public abstract class AbsGenreService
    {
        public List<AbsGenreCharacter> characterList;
        public List<string> imgSources;

        public bool CheckIfCharacterExists(string name)
        {
            bool output = characterList.Exists(x => (x.Name == name));
            return output;
        }

        public abstract void CreateChar(string name, string imgSource);
    }
}
