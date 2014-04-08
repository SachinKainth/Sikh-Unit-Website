using System.Collections.Generic;
using System.Linq;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic
{
    public class MusicVideoService : IMusicVideoService
    {
        private readonly IMusicVideoRepository _musicVideoRepository;

        public MusicVideoService(IMusicVideoRepository musicVideoRepository)
        {
            _musicVideoRepository = musicVideoRepository;
        }

        public List<MusicVideo> GetAllMusicVideos()
        {
            return _musicVideoRepository.GetAllMusicVideos().ToList();
        }
    }
}