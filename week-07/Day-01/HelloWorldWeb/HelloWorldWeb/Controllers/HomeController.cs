﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorldWeb.Controllers
{
    public class HomeController : Controller
    {
        [Route("hello")]
        public IActionResult Hello()
        {
            return Content("Hello World and Peti");
        }
    }
}