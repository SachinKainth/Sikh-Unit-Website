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
    class LiteratureServiceTests
    {
        private static List<Literature> GetLiteratures()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var literatureContext = new DatabaseContext();
            ILiteratureService literatureService =
                new LiteratureService(
                    new LiteratureRepository(literatureContext, new DbSetWrapper<Literature>(literatureContext), cache));

            List<Literature> literatures = literatureService.GetAllLiteratures();
            return literatures;
        }

        [Test]
        public void GetAllLiteratures__AllCorrectLiteratureNames()
        {
            var literatures = GetLiteratures();

            foreach (var literature in literatures)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.LiteraturesPath, literature.Name);
                Assert.IsTrue(File.Exists(path));
            }
        }

        [Test]
        public void GetAllLiteratures__AllCorrectLiteratureImageNames()
        {
            var literatures = GetLiteratures();

            foreach (var literature in literatures)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.LiteraturesImagesPath, literature.ImageName);
                Assert.IsTrue(File.Exists(path));
            }
        }

        [Test]
        public void GetAllLiteratures__CorrectNumberOfLiteratures()
        {
            var literatures = GetLiteratures();

            string[] allLiteraturePaths = Directory.GetFiles(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.LiteraturesPath));

            Assert.AreEqual(allLiteraturePaths.Length, literatures.Count);
        }
    }
}