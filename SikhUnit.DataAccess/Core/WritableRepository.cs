using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.DataAccess.Core
{
    public class WritableRepository<T> : IWritableRepository<T> where T : class, IEntity
    {
        protected DatabaseContext Context;

        public WritableRepository(DatabaseContext context)
        {
            Context = context;
        }

        public void Save(T t)
        {
            Context.SaveChanges();
        }
    }
}