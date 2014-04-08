using System.Collections.Generic;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.DataAccess.Core;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;

namespace SikhUnit.DataAccess.Repository
{
    public class TalkVideoRepository : Repository<TalkVideo>, ITalkVideoRepository
    {
        public TalkVideoRepository(DatabaseContext context, IDbSetWrapper<TalkVideo> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<TalkVideo> GetAllTalkVideos()
        {
            return FindAll();
        }
    }
}