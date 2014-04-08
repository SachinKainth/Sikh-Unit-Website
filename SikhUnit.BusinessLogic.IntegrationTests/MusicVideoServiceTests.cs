using System.Collections.Generic;
using System.IO;
using NUnit.Framework;
using SikhUnit.Cache;
using SikhUnit.Configuration;
using SikhUnit.DataAccess.Context;
using SikhUnit.DataAccess.Core;
using SikhUnit.DataAccess.Repository;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic.IntegrationTests
{
    [TestFixture]
    class MusicVideoServiceTests
    {
        [Test]
        public void GetAllMusicVideos__AllCorrectMusicVideoNames()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var musicVideoContext = new DatabaseContext();
            IMusicVideoService musicVideoService = 
                new MusicVideoService(
                    new MusicVideoRepository(musicVideoContext, new DbSetWrapper<MusicVideo>(musicVideoContext), cache));

            List<MusicVideo> musicVideos = musicVideoService.GetAllMusicVideos();

            foreach (var musicVideo in musicVideos)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.MusicVideosPath, musicVideo.Name);
                Assert.IsTrue(File.Exists(path));
            }

            string[] allMusicVideoPaths = Directory.GetFiles(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.MusicVideosPath));

            Assert.AreEqual(allMusicVideoPaths.Length, musicVideos.Count);
        }
    }
}