using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNet.Mvc;
using MyProject.Models;
using Microsoft.Framework.DependencyInjection;

namespace MyProject.Controllers
{
    public class MoviesController : Controller
    {

        private IRepository _repo;


        // Poor Man's Repository
        // public MoviesController() : this(new EFRepository()) { }



        public MoviesController(IRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var movies = _repo.ListMovies();
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
                _repo.CreateMovie(movie);

                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var movie = _repo.FindMovie(id);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _repo.EditMovie(movie);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var movie = _repo.FindMovie(id);
            return View(movie);
        }

        [ActionName("Delete")]
        [HttpPost]
        public IActionResult DeleteReally(int id)
        {
            _repo.DeleteMovie(id);
            return RedirectToAction("Index");
        }

    }
}
