using System.Collections.Generic;
using SikhUnit.Domain.Entity;

namespace SikhUnit.Domain.Interface.Service
{
    public interface IAlbumService
    {
        List<Album> GetAllAlbums();
        Album GetAlbum(int id);
    }
}