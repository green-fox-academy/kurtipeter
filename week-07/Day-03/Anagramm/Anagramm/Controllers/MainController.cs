using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Anagramm.Anagram;
using Microsoft.AspNetCore.Mvc;

namespace Anagramm.Controllers
{
    public class MainController : Controller
    {
        private IAnagramm x;

        public MainController(IAnagramm x)
        {
            this.x = x;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View(x);
        }

        [HttpPost("/")]
        public IActionResult Anagramm(string anagram)
        {
            x.MakeAnagramm(anagram);
            return Redirect("/");
        }
    }
}