using System.Collections.Generic;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.DataAccess.Core;

namespace SikhUnit.DataAccess.Repository
{
    public class MusicVideoRepository : Repository<MusicVideo>, IMusicVideoRepository
    {
        public MusicVideoRepository(DatabaseContext context, IDbSetWrapper<MusicVideo> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<MusicVideo> GetAllMusicVideos()
        {
            return FindAll();
        }
    }
}