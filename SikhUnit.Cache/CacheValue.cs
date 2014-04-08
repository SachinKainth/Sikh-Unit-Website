using System;
using System.Collections.Generic;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Cache
{
    public class CacheValue
    {
        public IEnumerable<IEntity> Entities { get; set; }
        public DateTime Expiration { get; set; }
        public bool IsExpired { get; set; }
    }
}