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
        public Dictionary<string, string> imgSources;
        public Nutrition nutrition;
        public int currentChar;
        public List<AttackMoves> attackMovesPool = new List<AttackMoves>();

        public AbsGenreService()
        {
            nutrition = new Nutrition();
        }

        public bool CheckIfCharacterExists(string name)
        {
            bool output = characterList.Exists(x => (x.Name == name));
            return output;
        }

        public void AddNewDrink(string drink)
        {
            nutrition.Drinks.Add(drink);
        }

        public void AddNewFood(string food)
        {
            nutrition.Foods.Add(food);
        }

        public bool CheckIfItExists(string type, string checkThis)
        {
            bool output;
            if (type == "Foods")
            {
                output = nutrition.Foods.Contains(checkThis);
                return output;
            }
            output = nutrition.Drinks.Contains(checkThis);
            return output;
        }

        public void SetCurrentChar(string name)
        {
            if (CheckIfCharacterExists(name))
            {
                currentChar = characterList.FindIndex(x => (x.Name == name));
            }
        }


        public abstract void CreateChar(string name, string imgSource);
        public abstract void CreateChar(string name);
    }
}
