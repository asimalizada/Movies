using System.Collections.Generic;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);
        List<Movie> GetAll();
        List<Movie> GetById(int id);
        List<Movie> GetByMovieName(string movieName);
        List<Movie> GetByGenreId(int genreId);
        decimal GetMinImdb();
        decimal GetMaxImdb();
        List<decimal> GetImdbs();
        List<Movie> GetByImdb(decimal min, decimal max);
        List<MovieDetail> GetMovieDetails();
        int GetNextId();
    }
}
