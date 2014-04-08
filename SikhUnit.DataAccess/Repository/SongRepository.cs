using System.Collections.Generic;
using System.Linq;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.DataAccess.Core;
using SikhUnit.Domain.Interface.Repository;

namespace SikhUnit.DataAccess.Repository
{
    public class SongRepository : Repository<Song>, ISongRepository
    {
        public SongRepository(DatabaseContext context, IDbSetWrapper<Song> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<Song> GetAllSongsForAlbum(int albumId)
        {
            return FindAll().Where(s => s.Album.Id == albumId);
        }
    }
}