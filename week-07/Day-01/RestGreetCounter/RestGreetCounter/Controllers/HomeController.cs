using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestGreetCounter.Modules;

namespace RestGreetCounter.Controllers
{
    [Route("api")]
    public class HomeController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greet = new Greeting() { Name = "Hello Wolrd " + name };
            return new JsonResult(greet);
        }
    }
}