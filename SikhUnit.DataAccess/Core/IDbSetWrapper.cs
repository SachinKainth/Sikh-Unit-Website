using System.Data.Entity;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.DataAccess.Core
{
    public interface IDbSetWrapper<T> where T : class, IEntity
    {
        DbSet<T> DbSet { get; }
    }
}