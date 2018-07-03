using CharacterClub.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace CharacterClub.Services
{
    public class PokemonService : AbsGenreService
    {
        //public List<AttackMoves> attackMovesPool = new List<AttackMoves>();

        public PokemonService()
        {
            imgSources = new Dictionary<string, string>
            {
                {"Pikachu", "/../img_pokemon/pikachu.png" },
                {"Bulbasaur", "/../img_pokemon/bulbasaur.png" },
                {"Charmander", "/../img_pokemon/charmander.jpg" },
                {"Squirtle", "/../img_pokemon/squirtle.png" }
            };
            characterList = new List<AbsGenreCharacter>();
            PopulateMoves();
        }

        public override void CreateChar(string name, string imgSource)
        {
            Pokemon pokemon = new Pokemon { Name = name};
            pokemon.imgSource = imgSource;
            characterList.Add(pokemon);
        }

        public override void CreateChar(string name)
        {
            Pokemon pokemon = new Pokemon { Name = name};
            characterList.Add(pokemon);
        }

        private List<string[]> ReadInFile(string path)
        {
            string[] raw = File.ReadAllLines(path);
            List<string[]> processed = new List<string[]>();

            for (int i = 0; i < raw.Length; i++)
            {
                processed.Add(raw[i].Split(","));
            }
            return processed;
        }

        private void PopulateMoves()
        {
            List<string[]> raw = ReadInFile(@"F:\greenfox\kurtipeter\week-07\Day-04\CharacterClub\CharacterClub\wwwroot\moves_pokemon\pokemonmoves.txt");
            foreach (var item in raw)
            {
                AttackMoves attack = new AttackMoves()
                {
                    Name = item[0],
                    AttackType = item[1],
                    Power = ValidateStringToInt(item[3])
                };
                attackMovesPool.Add(attack);
            }
        }
        private int ValidateStringToInt(string input)
        {
            int output = 0;
            if (Int32.TryParse(input, out output))
            {
                output = Int32.Parse(input);
                return output;
            }
            return 0;
        }
    }
}
