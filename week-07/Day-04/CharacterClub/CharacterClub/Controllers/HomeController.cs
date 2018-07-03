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
            return View(homeService);
        }

        [HttpPost("/")]
        public IActionResult Create(string name, string img)
        {
            homeService.CreateChar(name, img);
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
                homeService.SetCurrentChar(name);
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
            return View(homeService);
        }

        [HttpPost("/nutritionStore")]
        public IActionResult AddNutritionToChar(string drink, string food)
        {
            if (drink != null)
            {
                homeService.characterList[homeService.currentChar].Drink = drink;
            }
            if (food != null)
            {
                homeService.characterList[homeService.currentChar].Food = food;
            }
            return Redirect("/nutritionStore");
        }

        [HttpPost("/nutritionStore/addToStore")]
        public IActionResult AddNutritionToStore(string drink, string food)
        {
            if (!homeService.CheckIfItExists("Drinks", drink))
            {
                homeService.AddNewDrink(drink);
            }
            if (!homeService.CheckIfItExists("Foods", food))
            {
                homeService.AddNewFood(food);
            }
            return Redirect("/nutritionStore");
        }

        [HttpGet("/actionHistory")]
        public IActionResult ActionHistory()
        {
            return View();
        }

        [HttpGet("/trickCenter")]
        public IActionResult TrickCenter()
        {
            return View(homeService);
        }

        [HttpPost("/trickCenter")]
        public IActionResult AddTrick(ICollection<string> attacks)
        {
            return View("AddTrick", attacks);
        }
    }
}