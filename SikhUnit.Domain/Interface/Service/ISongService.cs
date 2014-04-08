using System.Collections.Generic;
using SikhUnit.Domain.Entity;

namespace SikhUnit.Domain.Interface.Service
{
    public interface ISongService
    {
        List<Song> GetAllSongsForAlbum(int albumId);
    }
}