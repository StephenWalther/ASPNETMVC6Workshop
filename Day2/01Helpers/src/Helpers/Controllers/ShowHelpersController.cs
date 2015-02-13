using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Helpers.Controllers
{
    public class ShowHelpersController : Controller
    {
        public IActionResult RazorHelper()
        {
            return View();
        }

        public IActionResult ExtensionMethod()
        {
            return View();
        }

    }
}
