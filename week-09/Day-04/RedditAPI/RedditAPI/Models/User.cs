using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int UserPassword { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
