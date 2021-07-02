using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IMovieService
    {
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(Movie movie);
        List<Movie> GetAll();
    }
}
