using System.Collections.Generic;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.DataAccess.Core;

namespace SikhUnit.DataAccess.Repository
{
    public class ImageRepository : Repository<Image>, IImageRepository
    {
        public ImageRepository(DatabaseContext context, IDbSetWrapper<Image> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<Image> GetAllImages()
        {
            return FindAll();
        }
    }
}