using System.Linq;
using Microsoft.AspNet.Mvc;
using Repository.Models;
using Microsoft.Framework.DependencyInjection;

namespace Repository.Controllers
{
    public class MoviesController : Controller
    {

        private IGenericRepository _repo;


        public MoviesController(IGenericRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            // Just action movies?
            //var movies = from m in _repo.Query<Movie>()
            //             where m.Category.Name == "Action"
            //             select m;

            var movies = _repo.Query<Movie>().ToList();
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
                _repo.Add<Movie>(movie);
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var movie = _repo.Query<Movie>().First(m => m.Id == id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var originalMovie = _repo.Query<Movie>().First(m => m.Id == movie.Id);
                originalMovie.Title = movie.Title;
                originalMovie.Director = movie.Director;
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var movie = _repo.Query<Movie>().First(m => m.Id == id);
            return View(movie);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeleteReally(int id)
        {
            var movie = _repo.Query<Movie>().First(m => m.Id == id);
            _repo.Delete<Movie>(movie);
            _repo.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
