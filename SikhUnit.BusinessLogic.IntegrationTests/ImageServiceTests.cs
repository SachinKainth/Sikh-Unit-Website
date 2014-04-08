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
    class ImageServiceTests
    {
        [Test]
        public void GetAllImages__AllCorrectImageNames()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var imageContext = new DatabaseContext();
            IImageService imageService = new ImageService(new ImageRepository(imageContext, new DbSetWrapper<Image>(imageContext), cache));

            List<Image> images = imageService.GetAllImages();

            foreach (var image in images)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.ImagesPath, image.Name);
                Assert.IsTrue(File.Exists(path));
            }

            string[] allImagePaths = Directory.GetFiles(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.ImagesPath));

            Assert.AreEqual(allImagePaths.Length, images.Count);
        }
    }
}