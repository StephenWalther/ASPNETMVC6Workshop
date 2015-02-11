using System;
using System.Collections;
using System.Collections.Generic;

namespace FirstApp.Models
{
    public class Repository
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie { Title="Star Wars", Director="Lucas"},
                new Movie { Title="King Kong", Director="Jackson" },
                new Movie { Title="Memento", Director="Nolan" }
            };

        }
    }
}