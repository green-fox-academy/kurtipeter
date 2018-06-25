using BankOfSimba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.ViewModels
{
    public class HomeIndexViewModel
    {
        public BankAccount BankAcc { get; set; }
        public List<BankAccount> ListOfBankAcc { get; set; }
    }
}
