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
        [Route("")]
        public IActionResult MainIndex()
        {
            return Redirect("main");
        }

        public static HomeIndexViewModel hivm = new HomeIndexViewModel();

        [Route("create")]
        public IActionResult Create()
        {
            hivm.ListOfBankAcc.Add(new BankAccount { Name = "Rafiki", Balance = 1500, AnimalType = "mandrill", King = false });
            hivm.ListOfBankAcc.Add(new BankAccount { Name = "Zazu", Balance = 2130, AnimalType = "red-billed hornbill", King = false });
            hivm.ListOfBankAcc.Add(new BankAccount { Name = "Scar", Balance = 900, AnimalType = "lion", King = false });
            hivm.ListOfBankAcc.Add(new BankAccount { Name = "Timon", Balance = 130, AnimalType = "meerkat", King = false });
            hivm.ListOfBankAcc.Add(new BankAccount { Name = "Pumba", Balance = 3, AnimalType = "warthog", King = false });
            hivm.ListOfBankAcc.Add(new BankAccount { Name = "Simba", Balance = 2000, AnimalType = "lion", King = true });

            return Redirect("simba");
        }

        [Route("simba")]
        public IActionResult Index()
        {
            return View(hivm);
        }

        [HttpPost]
        [Route("addMoney")]
        public IActionResult AddMoney()
        {
            for (int i = 0; i < hivm.ListOfBankAcc.Count; i++)
            {
                if (hivm.ListOfBankAcc[i].King == true)
                {
                    hivm.ListOfBankAcc[i].Balance += 100;

                }
                else
                {
                    hivm.ListOfBankAcc[i].Balance += 10;
                }
            }
            return Redirect("simba");
        }

        [HttpPost]
        [Route("addBankAcc")]
        public IActionResult AddBankAcc(string name, string animalType, int balance, bool king)
        {
            hivm.ListOfBankAcc.Add(new BankAccount { Name = name, AnimalType = animalType, Balance = balance, King = king });
            return Redirect("simba");
        }
    }
}