using System.Collections.Generic;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Interface.Repository
{
    public interface IAlbumRepository : IRepository<Album>
    {
        IEnumerable<Album> GetAllAlbums();
        Album GetAlbum(int id);
    }
}