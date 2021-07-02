using System.Collections.Generic;
using System.Runtime.InteropServices;
using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

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
    }
}
