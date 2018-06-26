using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BankOfSimba.Controllers
{   
    [Route("main")]
    public class MainController : Controller
    {
        public IActionResult MainIndex()
        {
            return View();
        }

        [HttpPost]
        [Route("ThingsDoer")]
        public IActionResult ThingsDoer()
        {
            return Redirect("../create");
        }
    }
}