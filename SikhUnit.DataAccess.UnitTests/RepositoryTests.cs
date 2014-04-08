using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.DataAccess.Core;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.DataAccess.UnitTests
{
    [TestFixture]
    class RepositoryTests
    {
        [Test]
        public void FindAll_CacheDoesntContainItem_GetsFromDataSource()
        {
            var albumContext = new DatabaseContext();

            var dbSetWrapperMock = new Mock<IDbSetWrapper<Album>>();
            dbSetWrapperMock.SetupGet(m => m.DbSet).Returns(albumContext.Set<Album>);

            var cacheMock = new Mock<IEntityCache>();
            cacheMock.Setup(m => m.GetCacheItem(It.IsAny<string>())).Returns((CacheValue) null);

            IRepository<Album> repository = new Repository<Album>(albumContext, dbSetWrapperMock.Object, cacheMock.Object);

            repository.FindAll();

            dbSetWrapperMock.Verify(m => m.DbSet, Times.Once);
            cacheMock.Verify(m => m.SetCacheItem(It.IsAny<string>(), It.IsAny<IEnumerable<IEntity>>()), Times.Once);
        }

        [Test]
        public void FindAll_CacheItemExpired_GetsFromDataSource()
        {
            var albumContext = new DatabaseContext();

            var dbSetWrapperMock = new Mock<IDbSetWrapper<Album>>();
            dbSetWrapperMock.SetupGet(m => m.DbSet).Returns(albumContext.Set<Album>);

            var cacheMock = new Mock<IEntityCache>();
            cacheMock.Setup(m => m.GetCacheItem(It.IsAny<string>())).Returns(new CacheValue { IsExpired = true });

            IRepository<Album> repository = new Repository<Album>(albumContext, dbSetWrapperMock.Object, cacheMock.Object);

            repository.FindAll();

            dbSetWrapperMock.Verify(m => m.DbSet, Times.Once);
            cacheMock.Verify(m => m.SetCacheItem(It.IsAny<string>(), It.IsAny<IEnumerable<IEntity>>()), Times.Once);
        }

        [Test]
        public void FindAll_CacheContainsItem_GetsFromCache()
        {
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

            var albumContext = new DatabaseContext();

            var dbSetWrapperMock = new Mock<IDbSetWrapper<Album>>();
            dbSetWrapperMock.SetupGet(m => m.DbSet).Returns(albumContext.Set<Album>);

            var cacheMock = new Mock<IEntityCache>();
            cacheMock.Setup(m => m.GetCacheItem(It.IsAny<string>())).Returns(new CacheValue { Entities = albums });

            IRepository<Album> repository = new Repository<Album>(albumContext, dbSetWrapperMock.Object, cacheMock.Object);

            repository.FindAll();

            dbSetWrapperMock.Verify(m => m.DbSet, Times.Never);
            cacheMock.Verify(m => m.SetCacheItem(It.IsAny<string>(), It.IsAny<IEnumerable<IEntity>>()), Times.Never);
        }
    }
}