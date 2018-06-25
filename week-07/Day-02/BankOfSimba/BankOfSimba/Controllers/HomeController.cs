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
            //BankAccount simbaAcc = new BankAccount() { Name = "Simba", Balance = 2000, AnimalType = "lion" };

            List<BankAccount> listOfBankAccs = new List<BankAccount>
            {
                new BankAccount {Name = "Rafiki", Balance = 1500, AnimalType= "mandrill"},
                new BankAccount {Name = "Mufasa", Balance = 2130, AnimalType= "lion"},
                new BankAccount {Name = "Scar", Balance = 900, AnimalType= "lion"},
                new BankAccount {Name = "Timon", Balance = 130, AnimalType= "meerkat"},
                new BankAccount {Name = "Pumba", Balance = 3, AnimalType= "warthog"}
            };

            HomeIndexViewModel hivm = new HomeIndexViewModel() { ListOfBankAcc = listOfBankAccs };
            return View(hivm);
        } 
    }
}