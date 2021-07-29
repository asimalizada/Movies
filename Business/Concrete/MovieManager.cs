using System.Collections.Generic;
using System.Linq;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.CrossCuttingConcerns.Validation;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;
using FluentValidation;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private IMovieDal _movieDal;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }

        public void Add(Movie movie)
        {
            ValidatorTool.ValidateGeneric<Movie>(movie, new MovieValidator());
            //... 
            _movieDal.Add(movie);
        }

        public void Update(Movie movie)
        {

            _movieDal.Update(movie);
        }

        public void Delete(Movie movie)
        {
            _movieDal.Delete(movie);
        }

        public List<Movie> GetAll()
        {
            return _movieDal.GetAll();
        }

        public List<Movie> GetById(int id)
        {
            return _movieDal.GetAll(m => m.MovieId == id);
        }

        public List<Movie> GetByMovieName(string movieName)
        {
            return _movieDal.GetAll(m => m.MovieName
                .ToLower().Contains(movieName.ToLower()));
        }

        public List<Movie> GetByGenreId(int genreId)
        {
            return _movieDal.GetAll(m => m.GenreId == genreId);
        }

        public List<decimal> GetImdbs()
        {
            return this.GetAll().Select(m => m.Imdb).ToList();
        }

        public List<Movie> GetByImdb(decimal min, decimal max)
        {
            return this._movieDal
                .GetAll(m => m.Imdb >= min & m.Imdb <= max);
        }

        public List<MovieDetail> GetMovieDetails()
        {
            return this._movieDal.GetMovieDetails();
        }

        public int GetNextId()
        {
            return this._movieDal.GetNextId();
        }

        public decimal GetMinImdb()
        {
            return this.GetImdbs().Min();
        }

        public decimal GetMaxImdb()
        {
            return GetImdbs().Max();
        }
    }
}
