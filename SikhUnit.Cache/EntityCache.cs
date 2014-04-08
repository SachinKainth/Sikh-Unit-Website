using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Cache
{
    public class EntityCache : IEntityCache
    {
        private static ConcurrentDictionary<string, CacheValue> _cache;
        private static int _durationnMinutes;
        private static volatile EntityCache _instance;
        private static readonly object SyncRoot = new object();

        internal EntityCache()
        {
            _cache = new ConcurrentDictionary<string, CacheValue>();
        }        
        static EntityCache() {}

        public static EntityCache Instance(int durationnMinutes)
        {
            _durationnMinutes = durationnMinutes;
            if (_instance == null)
            {
                lock (SyncRoot)
                {
                    if (_instance == null)
                    {
                        _instance = new EntityCache();
                    }
                }
            }
            return _instance;
        }

        public CacheValue GetCacheItem(string key)
        {
            if (_cache.ContainsKey(key))
            {
                if (_cache[key].Expiration < DateTime.UtcNow)
                {
                    _cache[key].IsExpired = true;
                }
                return _cache[key];
            }

            return null;
        }

        public void SetCacheItem(string key, IEnumerable<IEntity> value)
        {
            lock (SyncRoot)
            {
                RemoveFromCache(key);

                _cache.TryAdd(key,
                    new CacheValue
                    {
                        Entities = value,
                        Expiration = DateTime.UtcNow.AddMinutes(_durationnMinutes),
                        IsExpired = false
                    });
            }
        }

        public void RemoveFromCache(string key)
        {
            if (_cache.ContainsKey(key))
            {
                CacheValue oldEntities;
                _cache.TryRemove(key, out oldEntities);
            }
        }
    }
}