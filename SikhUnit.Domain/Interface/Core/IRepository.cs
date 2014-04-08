using System.Linq;

namespace SikhUnit.Domain.Interface.Core
{
    public interface IRepository<out T> where T : IEntity
    {
        IQueryable<T> FindAll();
    }
}