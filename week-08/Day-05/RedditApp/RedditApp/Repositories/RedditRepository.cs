using RedditApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditApp.Repositories
{
    public class RedditRepository : IRepository<Post,int>
    {
        RedditDbContext db;
        public RedditRepository(RedditDbContext db)
        {
            this.db = db;
        }

        public void Create(Post element)
        {
            db.Posts.Add(element);
            Save();
        }

        public void Delete(Post element)
        {
            db.Posts.Remove(element);
            Save();
        }

        public IEnumerable<Post> GetAllElement()
        {
            return db.Posts;
        }

        public Post GetT(int tkey)
        {
            return db.Posts.FirstOrDefault(p => p.Id == tkey);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Post element)
        {
            db.Posts.Update(element);
            Save();
        }
    }
}
