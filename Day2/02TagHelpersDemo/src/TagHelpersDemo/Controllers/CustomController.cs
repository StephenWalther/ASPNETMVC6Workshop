using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TagHelpersDemo.Controllers
{
    public class CustomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
