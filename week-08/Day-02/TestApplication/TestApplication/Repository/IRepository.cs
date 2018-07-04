using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Context;

namespace TestApplication.Repository
{
    public interface IRepository
    {
        void AddPokemon(Pokemon pokemon);
        List<Pokemon> GetPokemons();
    }
}
