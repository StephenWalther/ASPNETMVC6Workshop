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

        public IActionResult Edit(int id)
        {
            var movie = _db.Movies.First(m => m.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                // bad method
                //_db.Entry(movie).State = Microsoft.Data.Entity.EntityState.Modified;
                //_db.SaveChanges();

                // good method
                var originalMovie = _db.Movies.First(m => m.Id == movie.Id);
                originalMovie.Title = movie.Title;
                originalMovie.Director = movie.Director;
                _db.SaveChanges(); 

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var movie = _db.Movies.First(m => m.Id == id);
            return View(movie);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeleteReally(int id)
        {
            _db.Movies.Remove(new Movie { Id = id });
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
