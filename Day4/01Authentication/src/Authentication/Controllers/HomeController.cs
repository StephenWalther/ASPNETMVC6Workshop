using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using System.Security.Claims;

namespace Authentication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var user = (ClaimsPrincipal)this.User;
            ViewBag.IsEditor = user.FindFirst("CanEdit") != null;
            return View();
        }

        [Authorize("CanEdit", "true")]
        public IActionResult Edit()
        {
            return View();
        }

  


        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}