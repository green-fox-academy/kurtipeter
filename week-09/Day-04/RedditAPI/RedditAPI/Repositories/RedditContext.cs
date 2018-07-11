using Microsoft.EntityFrameworkCore;
using RedditAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Repositories
{
    public class RedditContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public RedditContext(DbContextOptions<RedditContext> options) : base(options)
        {

        }
    }
}
