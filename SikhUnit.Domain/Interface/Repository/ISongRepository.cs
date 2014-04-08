using System.Collections.Generic;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Interface.Repository
{
    public interface ISongRepository : IRepository<Song>
    {
        IEnumerable<Song> GetAllSongsForAlbum(int albumId);
    }
}