using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditAPI.Repositories
{
    public class AbsRepository<T> where T : class
    {
        private DbContext context;

        public AbsRepository(RedditContext context)
        {
            this.context = context;
        }

        protected DbSet<T> dbSet;

        public List<T> GetAllElementsFromDb()
        {
            return dbSet.ToList();
        }

        public void UpdateOneElementInDb(T element)
        {
            dbSet.Update(element);
            context.SaveChanges();
        }

        public void CreateOneElementInDb(T element)
        {
            dbSet.Add(element);
            context.SaveChanges();
        }

        public void DeleteOneElementInDb(T element)
        {
            dbSet.Remove(element);
            context.SaveChanges();
        }
    }
}
