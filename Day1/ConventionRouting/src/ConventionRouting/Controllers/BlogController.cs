using Microsoft.AspNet.Mvc;
using System;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConventionRouting.Controllers
{
    public class BlogController : Controller
    {
        // GET: /<controller>/
        public IActionResult GetEntryById(int id)
        {
            return Content("You requested the blog entry with id " + id);
        }

        public IActionResult GetEntryByDate(DateTime date)
        {
            return Content("You requested the blog entry with date " + date.ToString());
        }


    }
}
