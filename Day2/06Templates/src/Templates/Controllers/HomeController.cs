using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Templates.Models;

namespace Templates.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Details()
        {
            var movie = new Movie
            {
                Title = "Star Wars",
                IsReleased = true,
                ReleaseDate = DateTime.Now
            };
            return View(movie);
        }


        public IActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Title="Star Wars", IsReleased=true, ReleaseDate=DateTime.Parse("1/1/1979")},
                new Movie { Title="Star Wars III", IsReleased=true, ReleaseDate=DateTime.Parse("1/1/2004")},
                new Movie { Title="Star Wars VI", IsReleased=false, ReleaseDate=DateTime.Parse("1/1/2015")}
            };
            return View(movies);
        }


        public IActionResult Edit()
        {
            var movieToEdit = new Movie
            {
                Title = "Star Wars",
                IsReleased = true,
                ReleaseDate = DateTime.Now
            };
            return View(movieToEdit);
        }


    }
}