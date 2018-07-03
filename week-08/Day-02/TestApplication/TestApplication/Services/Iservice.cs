using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Context;

namespace TestApplication.Services
{
    public interface IService
    {
        void AddPokemon(Pokemon pokemon);
        ICollection<Pokemon> GetPokemons();
    }
}
