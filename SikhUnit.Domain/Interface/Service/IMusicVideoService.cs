using System.Collections.Generic;
using SikhUnit.Domain.Entity;

namespace SikhUnit.Domain.Interface.Service
{
    public interface IMusicVideoService
    {
        List<MusicVideo> GetAllMusicVideos();
    }
}