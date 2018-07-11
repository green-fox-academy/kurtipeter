using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public DateTime TimeStamp { get; set; }
        public int Score { get; set; }

        public Post()
        {
            TimeStamp = DateTime.Now;
            Score = 0;
        }
    }
}
