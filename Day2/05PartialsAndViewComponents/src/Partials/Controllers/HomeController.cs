using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Partials.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Simple()
        {
            return View();
        }

        public IActionResult VC()
        {
            return View();
        }


    }
}