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
        [Test]
        public void GetAllLiteratures__AllCorrectLiteratureNames()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var literatureContext = new DatabaseContext();
            ILiteratureService literatureService = 
                new LiteratureService(
                    new LiteratureRepository(literatureContext, new DbSetWrapper<Literature>(literatureContext), cache));

            List<Literature> literatures = literatureService.GetAllLiteratures();

            foreach (var literature in literatures)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.LiteraturesPath, literature.Name);
                Assert.IsTrue(File.Exists(path));
            }

            string[] allLiteraturePaths = Directory.GetFiles(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.LiteraturesPath));

            Assert.AreEqual(allLiteraturePaths.Length, literatures.Count);
        }
    }
}