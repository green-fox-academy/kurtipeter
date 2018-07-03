using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApplication.Context;
using TestApplication.Repository;

namespace TestApplication.Services
{
    public class PetiService : IService
    {
        IRepository repository;

        public PetiService(IRepository repository)
        {
            this.repository = repository;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            repository.AddPokemon(pokemon);
        }

        public ICollection<Pokemon> GetPokemons()
        {
            return repository.GetPokemons();
        }
    }
}
