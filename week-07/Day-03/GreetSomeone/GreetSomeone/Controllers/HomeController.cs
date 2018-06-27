using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GreetSomeone
{
    public class HomeController : Controller
    {
        private AbstractGreet greetService;

        public HomeController(AbstractGreet greetService)
        {
            this.greetService = greetService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Greet(string name)
        {
            greetService.name = name;
            return Redirect("greet");
        }

        [HttpGet("greet")]
        public IActionResult Show()
        {
            return View(greetService);
        }
    }
}
