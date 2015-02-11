using FirstApp.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstApp.Controllers
{
    public class MoviesController : Controller
    {

        private Repository _repository = new Repository();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var movies = _repository.ListMovies();
            return View(movies);
        }
    }
}
