using Associations.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;


namespace Associations.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesDB _db = new MoviesDB();

        public IActionResult Index()
        {
            // throws null reference exception because no movies
            //var categories = _db.Categories.ToList();

            // new syntax for eager loading .Include().ThenInclude()
            var categories = _db.Categories.Include(c => c.Movies).ToList();


            return View(categories);
        }
    }
}
