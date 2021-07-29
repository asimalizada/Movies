using System.Data.Entity;
using DataAccess.Concrete.EntityFramework.Mappers;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MovieMapper());
        }
    }
}
