using System.Collections.Generic;
using System.IO;
using System.Linq;
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
    class SongServiceTests
    {
        [Test]
        public void GetAllSongsForAlbum__AllCorrectSongNamesForEachAlbum()
        {
            EntityCache cache = EntityCache.Instance(SiteConfiguration.DurationMinutes);

            var albumContext = new DatabaseContext();
            IAlbumService albumService = new AlbumService(new AlbumRepository(albumContext, new DbSetWrapper<Album>(albumContext), cache));
            List<Album> albums = albumService.GetAllAlbums();

            var songContext = new DatabaseContext();
            ISongService songService = new SongService(new SongRepository(songContext, new DbSetWrapper<Song>(songContext), cache));

            foreach (var album in albums)
            {    
                List<Song> songs = songService.GetAllSongsForAlbum(album.Id);

                foreach (var song in songs)
                {
                    string path = Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.AlbumsPath, album.Name, song.Name);
                    Assert.IsTrue(File.Exists(path));
                }

                string[] allSongsForAlbumPath = Directory.GetFiles(Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.AlbumsPath, album.Name), "*.mp3");

                Assert.AreEqual(allSongsForAlbumPath.Length, songs.Count);

                string frontCoverPath =
                    Directory.GetFiles(
                        Path.Combine(SiteConfiguration.ContentPath, SiteConfiguration.AlbumsPath, album.Name), "*.jpg")
                        .Single();

                Assert.AreEqual("00 Front Cover.jpg", Path.GetFileName(frontCoverPath));
            }
        }
    }
}