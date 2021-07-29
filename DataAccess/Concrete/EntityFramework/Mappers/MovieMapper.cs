using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework.Mappers
{
    public class MovieMapper : EntityTypeConfiguration<Movie>
    {
        public MovieMapper()
        {
            ToTable("Movies");
            HasKey(m => m.MovieId);
            Property(m => m.MovieId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(m => m.MovieId).HasColumnName("Id");
            Property(m => m.MovieName).HasColumnName("MovieName");
            Property(m => m.Imdb).HasColumnName("Imdb");
            Property(m => m.GenreId).HasColumnName("GenreId");
        }
    }
}
