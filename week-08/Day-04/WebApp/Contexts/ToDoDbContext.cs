using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace ToDoApp.Contexts
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ThingToDo> toDoes { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options)
        {

        }
    }
}
