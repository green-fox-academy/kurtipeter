using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Frontend.Controllers
{
    public class HomeController : Controller
    {
        public Service service = new Service();
        // GET: /<controller>/
        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("index.html", "text/html");
        }

        [HttpGet("doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please provide an input!" });
            }
            else
            {
                return Json(new { received = input, result = 2 * input });
            }
        }

        [HttpGet("greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name == null)
            {
                return Json(new { error = "Please provide a name!" });
            }
            else if (title == null)
            {
                return Json(new { error = "Please provide a title!" });
            }
            else
            {
                return Json(new { welcome_message = "Oh, hi there " + name + ", my dear " + title + "!" });
            }
        }

        [HttpGet("appenda/{appendable}")]
        public IActionResult Append(string appendable)
        {
            return Json(new { appended = appendable + "a" });
        }

        [HttpPost("dountil/{what}")]
        public IActionResult DoUntil(string what, [FromBody] Number input)
        {
            if (what == "sum" && input.Until != 0)
            {
                return Json(new {result = service.Sumer(input.Until) });
            }
            else if(what == "factor" && input.Until != 0)
            { 
                return Json(new {result = service.Factorer(input.Until) });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

        [HttpPost("arrays")]
        public IActionResult ArrayHandlerFunction([FromBody] ArrayHandler input)
        {
            if (input.What == "multiply")
            {
                return Json(new { result = service.ArrayMultiply(input.Numbers) });
            }
            else if (input.What == "sum")
            {
                return Json(new { result = service.ArraySum(input.Numbers) });
            }
            else if (input.What == "double")
            {
                return Json(new { result = service.ArrayDoubler(input.Numbers) });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }
    }
}
