using System.Collections.Generic;

namespace MyProject.Models
{
    public interface IRepository
    {
        void CreateMovie(Movie movie);
        void DeleteMovie(int id);
        void EditMovie(Movie movie);
        Movie FindMovie(int id);
        IList<Movie> ListMovies();
    }
}