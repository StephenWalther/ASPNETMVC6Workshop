using Microsoft.AspNet.Mvc;
using Validation.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Validation.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            return View();
        }


    }
}
