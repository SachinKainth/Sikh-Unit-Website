using System.Linq;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.DataAccess.Core
{
    public class Repository<T> : IRepository<T> where T : class, IEntity
    {
        protected DatabaseContext Context;
        private readonly IDbSetWrapper<T> _dbSetWrapper;
        private readonly IEntityCache _entityCache;

        public Repository(DatabaseContext context, IDbSetWrapper<T> dbSetWrapper, IEntityCache entityCache)
        {
            Context = context;
            _dbSetWrapper = dbSetWrapper;
            _entityCache = entityCache;
        }

        public IQueryable<T> FindAll()
        {
            CacheValue cacheValue = _entityCache.GetCacheItem(typeof(T).Name);
            if (cacheValue == null || cacheValue.IsExpired)
            {
                IQueryable<T> queryable = _dbSetWrapper.DbSet.AsQueryable().OrderBy(e => e.Id);
                _entityCache.SetCacheItem(typeof(T).Name, queryable);
                return queryable;
            }
            return cacheValue.Entities.AsQueryable() as IQueryable<T>;
        }
    }
}