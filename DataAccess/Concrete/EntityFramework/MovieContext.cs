using System.Data.Entity;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

    }
}
