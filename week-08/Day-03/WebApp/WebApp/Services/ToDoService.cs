using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Services
{
    public class ToDoService
    {
        public List<ThingToDo> thingsToDo = new List<ThingToDo>();

        public void AddToDo(string descirption, int priority)
        {
            ThingToDo toDo = new ThingToDo()
            {
                Description = descirption,
                Priority = priority,
                IsDone = true
            };
            thingsToDo.Add(toDo);
            SortThingsToDo();
        }

        public void CheckToDo(string input)
        {
            int index = Int32.Parse(input);
            if (thingsToDo[index].IsDone == false)
            {
                thingsToDo[index].IsDone = true;
            }
            else
            {
                thingsToDo[index].IsDone = false;
            }
        }

        public void DeleteToDo(string input)
        {
            int index = Int32.Parse(input);
            thingsToDo.RemoveAt(index);
        }

        private void SortThingsToDo()
        {
            thingsToDo = thingsToDo.OrderBy(x => x.Priority).ToList();
        }
    }
}
