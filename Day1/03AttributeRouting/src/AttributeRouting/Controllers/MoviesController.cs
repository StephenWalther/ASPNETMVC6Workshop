using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AttributeRouting.Controllers
{
    [Route("Super")]
    public class MoviesController : Controller
    {
        // GET: /Super/Awesome
        [Route("Awesome")]    
        public IActionResult Index()
        {
            return Content("Awesome!");
        }

        // GET: /Fantastic
        [Route("/Fantastic")]
        public IActionResult Get()
        {
            return Content("Fantastic!");
        }
    }
}
