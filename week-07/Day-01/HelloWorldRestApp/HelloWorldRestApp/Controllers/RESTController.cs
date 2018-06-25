using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldRestApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldRestApp.Controllers
{
    [Route("api")]

    public class RESTController : Controller
    {
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greet = new Greeting() { Id = 1, Content = "Hello World " + name };
            return new JsonResult(greet);
        }

        [Route("greeting/{name}")]
        public IActionResult Greeting1([FromRoute]string name)
        {
            Greeting greet = new Greeting() { Id = 1, Content = "Hello World " + name };
            return new JsonResult(greet);
        }
    }
}