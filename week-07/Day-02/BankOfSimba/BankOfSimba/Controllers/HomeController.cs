using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;
using BankOfSimba.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{
    public class HomeController : Controller
    {
        [Route("simba")]
        public IActionResult Index()
        {
            BankAccount simbaAcc = new BankAccount() { Name = "Simba", Balance = 2000, AnimalType = "Animal.Lion" };

            HomeIndexViewModel hivm = new HomeIndexViewModel() { BankAcc = simbaAcc };
            return View(hivm);
        } 
    }
}