using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Context
{
    public class PetiDbContext : DbContext
    {
        public DbSet<Pokemon> Pokemons { get; set; }
        public PetiDbContext(DbContextOptions<PetiDbContext> options) : base(options)
        {

        }
    }
}
