using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SayHelloToAllTheWorld.Models;

namespace SayHelloToAllTheWorld.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting()
            {
                Name = name
            };

            return View(greeting);
        }

    }
}