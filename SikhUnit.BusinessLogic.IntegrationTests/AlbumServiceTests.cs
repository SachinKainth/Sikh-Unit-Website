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
    class AlbumServiceTests
    {
        [Test]
        public void GetAllAlbums__AllCorrectAlbumNames()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var albumContext = new DatabaseContext();
            IAlbumService albumService = new AlbumService(new AlbumRepository(albumContext, new DbSetWrapper<Album>(albumContext), cache));

            List<Album> albums = albumService.GetAllAlbums();

            foreach (var album in albums)
            {
                string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.AlbumsPath, album.Name);
                Assert.IsTrue(Directory.Exists(path));
            }

            string[] allAlbumPaths = Directory.GetDirectories(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.AlbumsPath));

            Assert.AreEqual(allAlbumPaths.Length, albums.Count);
        }

        [Test]
        public void GetAlbum_ValidAlbumId_AlbumReturned()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var albumContext = new DatabaseContext();
            IAlbumService albumService = new AlbumService(new AlbumRepository(albumContext, new DbSetWrapper<Album>(albumContext), cache));

            Album album = albumService.GetAlbum(1);

            Assert.IsNotNull(album);
        }

        [Test]
        public void GetAlbum_InValidAlbumId_NullReturned()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var albumContext = new DatabaseContext();
            IAlbumService albumService = new AlbumService(new AlbumRepository(albumContext, new DbSetWrapper<Album>(albumContext), cache));

            Album album = albumService.GetAlbum(int.MaxValue);

            Assert.IsNull(album);
        }
    }
}