﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankOfSimba.Models
{
    public class BankAccount
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string AnimalType { get; set; }

        public string GetBalance()
        {
            string output = string.Format("{0} Zebra", Balance);
            return output;
        }
    }
}
