using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;

namespace Helpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult UnTyped()
        {
            return View();
        }

        public IActionResult Typed()
        {
            return View();
        }

    }
}