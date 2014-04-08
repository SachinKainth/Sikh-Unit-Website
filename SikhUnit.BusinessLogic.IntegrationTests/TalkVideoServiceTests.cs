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
    class TalkVideoServiceTests
    {
        [Test]
        public void GetAllTalkVideos__AllCorrectTalkVideoNames()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var talkVideoContext = new DatabaseContext();
            ITalkVideoService talkVideoService = 
                new TalkVideoService(
                    new TalkVideoRepository(talkVideoContext, new DbSetWrapper<TalkVideo>(talkVideoContext), cache));

            List<TalkVideo> talkVideos = talkVideoService.GetAllTalkVideos();

            foreach (var talkVideo in talkVideos)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.TalkVideosPath, talkVideo.Name);
                Assert.IsTrue(File.Exists(path));
            }

            string[] allTalkVideoPaths = Directory.GetFiles(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.TalkVideosPath));

            Assert.AreEqual(allTalkVideoPaths.Length, talkVideos.Count);
        }
    }
}