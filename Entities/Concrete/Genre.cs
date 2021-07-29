using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
