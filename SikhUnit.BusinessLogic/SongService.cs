using System.Collections.Generic;
using System.Linq;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic
{
    public class SongService : ISongService
    {
        private readonly ISongRepository _songRepository;

        public SongService(ISongRepository songRepository)
        {
            _songRepository = songRepository;
        }

        public List<Song> GetAllSongsForAlbum(int albumId)
        {
            return _songRepository.GetAllSongsForAlbum(albumId).ToList();
        }
    }
}