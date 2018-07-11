using RedditAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Repositories
{
    public class UserRepository : AbsRepository<User>
    {
        public UserRepository(RedditContext context) : base(context)
        {
            dbSet = context.Users;
        }
    }
}
