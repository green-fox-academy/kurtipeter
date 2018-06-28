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
        AbsGenreService homeService;

        public HomeController(AbsGenreService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/")]
        public IActionResult Create(string name)
        {
            homeService.CreateChar(name, "test");
            return Redirect("/login");
        }

        [HttpGet("/login")]
        public IActionResult Login()
        {
            return View(true);
        }

        [HttpPost("/login")]
        public IActionResult LoginChar(string name)
        {
            bool isNameValid = homeService.CheckIfCharacterExists(name);
            if (isNameValid)
            {
                return Redirect("/show");
            }
            return View("Login", isNameValid);
        }

        [HttpGet("/show")]
        public IActionResult ShowChar()
        {
            return View(homeService);
        }

        //[HttpPost("/show")]
        //public IActionResult ReturnHome()
        //{
        //    return Redirect("/");
        //}

        [HttpGet("/nutritionStore")]
        public IActionResult Nutrition()
        {
            return View();
        }

        [HttpGet("/actionHistory")]
        public IActionResult ActionHistory()
        {
            return View();
        }

        [HttpGet("/trickCenter")]
        public IActionResult TrickCenter()
        {
            return View();
        }
    }
}