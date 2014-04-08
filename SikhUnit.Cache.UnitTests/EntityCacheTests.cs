using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Cache.UnitTests
{
    [TestFixture]
    internal class EntityCacheTests
    {
        private IEntityCache _entityCache;

        [SetUp]
        public void Setup()
        {
            _entityCache = EntityCache.Instance(1);
        }

        [Test]
        public void GetCacheItem_CacheEmpty_ReturnsNull()
        {
            string key = typeof (TalkVideo).Name;

            _entityCache.RemoveFromCache(key);
            var entities = _entityCache.GetCacheItem(key);

            Assert.AreEqual(null, entities);
        }

        [Test]
        public void GetCacheItem_CacheContainsItem_ReturnsItem()
        {
            string key = typeof (Album).Name;

            _entityCache.RemoveFromCache(key);

            IList<Album> albums = new List<Album>
                                  {
                                      new Album
                                      {
                                          AlbumNumber = 1, 
                                          Id = 1, 
                                          Songs = new List<Song>
                                                  {
                                                      new Song
                                                      {
                                                          AlbumId = 1, 
                                                          Id = 1, 
                                                          Name = "A Song",
                                                          TrackNumber = 1
                                                      }
                                                  },
                                          Name = "An Album"
                                      }
                                  };
            _entityCache.SetCacheItem(key, albums);
            var entities = _entityCache.GetCacheItem(key);

            var enumerable = entities.Entities as IList<IEntity> ?? entities.Entities.ToList();
            Assert.AreEqual(1, enumerable.Count());
            Assert.AreEqual(typeof(Album), enumerable.ElementAt(0).GetType());
            Assert.AreEqual("An Album", ((Album)enumerable.ElementAt(0)).Name);
            Assert.AreEqual(1, ((Album)enumerable.ElementAt(0)).Songs.Count);
            Assert.AreEqual("A Song", ((Album)enumerable.ElementAt(0)).Songs.ElementAt(0).Name);
        }

        [Test]
        public void GetCacheItem_ItemExpired_ReturnsItemWithIsExpiredSet()
        {
            string key = typeof(Album).Name;

            _entityCache.RemoveFromCache(key);

            _entityCache = EntityCache.Instance(-1);
            IList<Album> albums = new List<Album>
                                  {
                                      new Album
                                      {
                                          AlbumNumber = 1, 
                                          Id = 1, 
                                          Songs = new List<Song>
                                                  {
                                                      new Song
                                                      {
                                                          AlbumId = 1, 
                                                          Id = 1, 
                                                          Name = "A Song",
                                                          TrackNumber = 1
                                                      }
                                                  },
                                          Name = "An Album"
                                      }
                                  };
            _entityCache.SetCacheItem(key, albums);
            var entities = _entityCache.GetCacheItem(key);

            var enumerable = entities.Entities as IList<IEntity> ?? entities.Entities.ToList();
            Assert.AreEqual(1, enumerable.Count());
            Assert.AreEqual(typeof(Album), enumerable.ElementAt(0).GetType());
            Assert.AreEqual("An Album", ((Album)enumerable.ElementAt(0)).Name);
            Assert.AreEqual(1, ((Album)enumerable.ElementAt(0)).Songs.Count);
            Assert.AreEqual("A Song", ((Album)enumerable.ElementAt(0)).Songs.ElementAt(0).Name);
            Assert.AreEqual(true, entities.IsExpired);
        }

        [Test]
        public void GetCacheItem_ItemNotExpired_ReturnsItemWithIsExpiredNotSet()
        {
            string key = typeof(Album).Name;

            _entityCache.RemoveFromCache(key);

            _entityCache = EntityCache.Instance(1);
            IList<Album> albums = new List<Album>
                                  {
                                      new Album
                                      {
                                          AlbumNumber = 1, 
                                          Id = 1, 
                                          Songs = new List<Song>
                                                  {
                                                      new Song
                                                      {
                                                          AlbumId = 1, 
                                                          Id = 1, 
                                                          Name = "A Song",
                                                          TrackNumber = 1
                                                      }
                                                  },
                                          Name = "An Album"
                                      }
                                  };
            _entityCache.SetCacheItem(key, albums);
            var entities = _entityCache.GetCacheItem(key);

            var enumerable = entities.Entities as IList<IEntity> ?? entities.Entities.ToList();
            Assert.AreEqual(1, enumerable.Count());
            Assert.AreEqual(typeof(Album), enumerable.ElementAt(0).GetType());
            Assert.AreEqual("An Album", ((Album)enumerable.ElementAt(0)).Name);
            Assert.AreEqual(1, ((Album)enumerable.ElementAt(0)).Songs.Count);
            Assert.AreEqual("A Song", ((Album)enumerable.ElementAt(0)).Songs.ElementAt(0).Name);
            Assert.AreEqual(false, entities.IsExpired);
        }

        [Test]
        public void SetCacheItem_CacheDoesntContainItem_SetsItem()
        {
            string key = typeof(Album).Name;

            _entityCache.RemoveFromCache(key);

            IList<Album> albums = new List<Album>
                                  {
                                      new Album
                                      {
                                          AlbumNumber = 1, 
                                          Id = 1, 
                                          Songs = new List<Song>
                                                  {
                                                      new Song
                                                      {
                                                          AlbumId = 1, 
                                                          Id = 1, 
                                                          Name = "A Song",
                                                          TrackNumber = 1
                                                      }
                                                  },
                                          Name = "An Album"
                                      }
                                  };
            _entityCache.SetCacheItem(key, albums);

            var entities = _entityCache.GetCacheItem(key);

            var enumerable = entities.Entities as IList<IEntity> ?? entities.Entities.ToList();
            Assert.AreEqual(1, enumerable.Count());
            Assert.AreEqual(typeof(Album), enumerable.ElementAt(0).GetType());
            Assert.AreEqual("An Album", ((Album)enumerable.ElementAt(0)).Name);
            Assert.AreEqual(1, ((Album)enumerable.ElementAt(0)).Songs.Count);
            Assert.AreEqual("A Song", ((Album)enumerable.ElementAt(0)).Songs.ElementAt(0).Name);
        }

        [Test]
        public void SetCacheItem_CacheContainsItem_ReplacesWithNewItem()
        {
            string key = typeof(Album).Name;

            _entityCache.RemoveFromCache(key);

            IList<Album> albums = new List<Album>
                                  {
                                      new Album
                                      {
                                          AlbumNumber = 1, 
                                          Id = 1, 
                                          Songs = new List<Song>
                                                  {
                                                      new Song
                                                      {
                                                          AlbumId = 1, 
                                                          Id = 1, 
                                                          Name = "A Song",
                                                          TrackNumber = 1
                                                      }
                                                  },
                                          Name = "An Album"
                                      }
                                  };
            _entityCache.SetCacheItem(key, albums);

            IList<Album> newAlbums = new List<Album>
                                  {
                                      new Album
                                      {
                                          AlbumNumber = 2, 
                                          Id = 2, 
                                          Songs = new List<Song>
                                                  {
                                                      new Song
                                                      {
                                                          AlbumId = 2, 
                                                          Id = 2, 
                                                          Name = "A New Song",
                                                          TrackNumber = 2
                                                      }
                                                  },
                                          Name = "A New Album"
                                      }
                                  };
            _entityCache.SetCacheItem(key, newAlbums);

            var entities = _entityCache.GetCacheItem(key);

            var enumerable = entities.Entities as IList<IEntity> ?? entities.Entities.ToList();
            Assert.AreEqual(1, enumerable.Count());
            Assert.AreEqual(typeof(Album), enumerable.ElementAt(0).GetType());
            Assert.AreEqual("A New Album", ((Album)enumerable.ElementAt(0)).Name);
            Assert.AreEqual(1, ((Album)enumerable.ElementAt(0)).Songs.Count);
            Assert.AreEqual("A New Song", ((Album)enumerable.ElementAt(0)).Songs.ElementAt(0).Name);
        }
    }
}