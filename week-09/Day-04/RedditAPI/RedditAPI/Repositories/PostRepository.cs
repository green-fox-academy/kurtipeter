using RedditAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Repositories
{
    public class PostRepository : AbsRepository<Post>
    {
        public PostRepository(RedditContext context) : base(context)
        {
            dbSet = context.Posts;
        }
    }
}
