using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Context;

namespace TestApplication.Repository
{
    public class PetiRepository : IRepository
    {
        PetiDbContext dbContext;

        public PetiRepository(PetiDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            dbContext.Pokemons.Add(pokemon);
            dbContext.SaveChanges();
        }

        public List<Pokemon> GetPokemons()
        {
            return dbContext.Pokemons.ToList();
        }
    }
}
