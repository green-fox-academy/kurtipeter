using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    public class ToDoController : Controller
    {
        ToDoService toDoService;

        public ToDoController(ToDoService toDoService)
        {
            this.toDoService = toDoService;
        }
        [HttpGet("/ToDo")]
        public IActionResult Index()
        {
            if (toDoService.thingsToDo.Count > 0)
            {
               return View(toDoService.thingsToDo);
            }
            return View();
        }

        [HttpPost("/ToDo")]
        public IActionResult AddToDo(string description, int priority)
        {
            toDoService.AddToDo(description, priority);
            return Redirect("ToDo");
        }

        [HttpPost("/Check")]
        public IActionResult CheckToDo(string change)
        {
            toDoService.CheckToDo(change);
            return Redirect("ToDo");
        }

        [HttpPost("/Delete")]
        public IActionResult DeleteToDo(string delete)
        {
            toDoService.DeleteToDo(delete);
            return Redirect("ToDo");
        }
    }
}