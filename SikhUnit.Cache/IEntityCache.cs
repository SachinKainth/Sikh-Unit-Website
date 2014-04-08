using System.Collections.Generic;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Cache
{
    public interface IEntityCache
    {
        CacheValue GetCacheItem(string key);
        void SetCacheItem(string key, IEnumerable<IEntity> value);
        void RemoveFromCache(string key);
    }
}