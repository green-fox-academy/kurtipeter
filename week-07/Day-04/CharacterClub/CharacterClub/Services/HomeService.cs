using CharacterClub.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterClub.Services
{
    public class HomeService
    {
        public List<Character> characterList;

        public bool CheckIfCharacterExists(string name)
        {
            bool output = characterList.Exists(x => (x.Name == name));
            return output;
        }

    }
}
