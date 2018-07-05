using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Contexts;
using WebApp.Models;

namespace ToDoApp.Repositories
{
    public class ToDoRepository : IRepository<ThingToDo>
    {
        public ToDoDbContext db;

        public ToDoRepository(ToDoDbContext db)
        {
            this.db = db;
        }

        public void Create(ThingToDo element)
        {
            db.toDoes.Add(element);
            db.SaveChanges();
        }

        public void Delete(ThingToDo element)
        {
            db.toDoes.Remove(element);
            db.SaveChanges();
        }

        public List<ThingToDo> GetAllElements()
        {
            var output = db.toDoes.ToList();
            return output;
        }

        public void Update(ThingToDo element)
        {
            db.toDoes.Update(element);
            db.SaveChanges();
        }
    }
}
