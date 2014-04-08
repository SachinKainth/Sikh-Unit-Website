using System.Collections.Generic;
using System.Linq;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic
{
    public class TalkVideoService : ITalkVideoService
    {
        private readonly ITalkVideoRepository _talkVideoRepository;

        public TalkVideoService(ITalkVideoRepository talkVideoRepository)
        {
            _talkVideoRepository = talkVideoRepository;
        }

        public List<TalkVideo> GetAllTalkVideos()
        {
            return _talkVideoRepository.GetAllTalkVideos().ToList();
        }
    }
}