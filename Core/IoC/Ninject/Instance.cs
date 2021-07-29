using System.Linq;
using Ninject;
using Ninject.Modules;

namespace Core.IoC.Ninject
{
    public static class Instance
    {
        public static T GetInstance<T>(NinjectModule module)
        {
            var kernel = new StandardKernel(module);
            return kernel.Get<T>();
        }

        public static T GetInstance<T>(params INinjectModule[] modules)
        {
            var kernel = new StandardKernel(modules);
            return kernel.Get<T>();
        }
    }
}
