using DatabaseCodeFirst.Models;
using Microsoft.AspNet.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DatabaseCodeFirst.Controllers
{
    public class MoviesController : Controller
    {

        private MoviesDB _db = new MoviesDB();

        // GET: /<controller>/
        public IActionResult Index()
        {
            var movies = _db.Movies.ToList();
            return View(movies);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }


    }
}
