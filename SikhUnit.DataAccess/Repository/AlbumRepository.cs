using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.DataAccess.Core;

namespace SikhUnit.DataAccess.Repository
{
    public class AlbumRepository : Repository<Album>, IAlbumRepository
    {
        public AlbumRepository(DatabaseContext context, IDbSetWrapper<Album> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<Album> GetAllAlbums()
        {
            return FindAll().Include(a => a.Songs);
        }

        public Album GetAlbum(int id)
        {
            var albums = FindAll();
            return albums.FirstOrDefault(a => a.Id == id);
        }
    }
}