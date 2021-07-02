using System.Collections.Generic;
using Core.DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IMovieDal : IEntityRepository<Movie>
    {
    }
}
