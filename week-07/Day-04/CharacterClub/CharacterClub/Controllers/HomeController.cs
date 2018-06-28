using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CharacterClub.Characters;
using CharacterClub.Services;
using Microsoft.AspNetCore.Mvc;

namespace CharacterClub.Controllers
{
    public class HomeController : Controller
    {
        Character character;
        HomeService homeService = new HomeService();

        public HomeController(Character character)
        {
            this.character = character;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Create(string name)
        {
            //create a new instance of Character!!
            return Redirect("/login");
        }

        [HttpGet("/login")]
        public IActionResult Login(string name)
        {
            return View();
        }

        [HttpPost("/login")]
        public IActionResult LoginChar(string name)
        {
            //validate, if true redirect and show info
            return Redirect("/show");
        }

        [HttpGet("/show")]
        public IActionResult ShowChar()
        {
            //validate, if true redirect and show info
            return View();
        }

        [HttpPost("/show")]
        public IActionResult ReturnHome()
        {
            return Redirect("/");
        }
    }
}