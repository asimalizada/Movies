using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace Business.IoC.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMovieService>().To<MovieManager>().InSingletonScope();
            Bind<IGenreService>().To<GenreManager>().InSingletonScope();

            Bind<IMovieDal>().To<EfMovieDal>().InSingletonScope();
            Bind<IGenreDal>().To<EfGenreDal>().InSingletonScope();

        }
    }
}
