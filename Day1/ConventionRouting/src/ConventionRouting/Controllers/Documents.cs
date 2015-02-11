using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ConventionRouting.Controllers
{
    public class Documents : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(string path)
        {
            return Content("You requested the resource at " + path);
        }
    }
}
