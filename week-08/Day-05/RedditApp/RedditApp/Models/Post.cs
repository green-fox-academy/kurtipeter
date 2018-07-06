using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public int Rating { get; set; }
    }
}
