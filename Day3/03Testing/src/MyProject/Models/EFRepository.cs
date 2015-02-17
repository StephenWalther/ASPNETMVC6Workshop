using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProject.Models
{
    public class EFRepository : IRepository
    {
        private MoviesDB _db = new MoviesDB();

        public IList<Movie> ListMovies()
        {
            return _db.Movies.ToList();
        }

        public void CreateMovie(Movie movie)
        {
            _db.Movies.Add(movie);
            _db.SaveChanges();
        } 

        public Movie FindMovie(int id)
        {
            return _db.Movies.First(m => m.Id == id);
        }


        public void EditMovie(Movie movie)
        {
            var originalMovie = this.FindMovie(movie.Id);
            originalMovie.Title = movie.Title;
            originalMovie.Director = movie.Director;
            _db.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            _db.Movies.Remove(new Movie { Id = id });
            _db.SaveChanges();
        }


    }
}