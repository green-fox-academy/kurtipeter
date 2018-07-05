using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoApp.Repositories;
using WebApp.Models;

namespace WebApp.Services
{
    public class ToDoService
    {
        public ToDoRepository repo;

        public ToDoService(ToDoRepository repo)
        {
            this.repo = repo;
        }

        public void AddToDo(string descirption, int priority)
        {
            ThingToDo toDo = new ThingToDo()
            {
                Description = descirption,
                Priority = priority,
                IsDone = false
            };
            repo.Create(toDo);
        }

        public List<ThingToDo> ShowThingsToDo()
        {
            var toDoesToView = repo.GetAllElements();
            toDoesToView = toDoesToView.OrderBy(t => t.Priority).ToList();
            return toDoesToView;
        }
        
        public bool CheckIfDbIsNotNull()
        {
            bool output = repo.db.toDoes != null;
            return output;
        }

        public void CheckToDo(string input)
        {
            int index = Int32.Parse(input);
            ThingToDo updatingThisRecord = repo.db.toDoes.FirstOrDefault(t => t.Id == index);
            updatingThisRecord.IsDone = updatingThisRecord.IsDone ? false : true;
            repo.Update(updatingThisRecord);
        }

        public void DeleteToDo(string input)
        {
            int index = Int32.Parse(input);
            ThingToDo deleteRecord = repo.db.toDoes.FirstOrDefault(t => t.Id == index);
            repo.Delete(deleteRecord);
        }
    }
}
