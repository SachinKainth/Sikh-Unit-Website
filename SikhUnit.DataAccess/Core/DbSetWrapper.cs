using System.Data.Entity;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.DataAccess.Core
{
    public class DbSetWrapper<T> : IDbSetWrapper<T> where T : class, IEntity
    {
        protected DatabaseContext Context;

        public DbSetWrapper(DatabaseContext context)
        {
            Context = context;
        }

        public DbSet<T> DbSet { get { return Context.Set<T>(); } }
    }
}