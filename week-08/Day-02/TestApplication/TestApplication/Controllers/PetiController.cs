using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApplication.Context;
using TestApplication.Services;

namespace TestApplication.Controllers
{
    [Route("peti")]
    public class PetiController : Controller
    {
        IService myService;
        public PetiController(IService myService)
        {
            this.myService = myService;
        }

        [HttpGet]
        public IActionResult PetiIndex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPoke(string name, string type, int level)
        {
            myService.AddPokemon(new Pokemon { Name = name, Type = type, Level = level });
            return View(myService.GetPokemons());
        }
    }
}