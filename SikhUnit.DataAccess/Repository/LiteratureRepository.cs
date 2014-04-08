using System.Collections.Generic;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.DataAccess.Core;

namespace SikhUnit.DataAccess.Repository
{
    public class LiteratureRepository : Repository<Literature>, ILiteratureRepository
    {
        public LiteratureRepository(DatabaseContext context, IDbSetWrapper<Literature> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<Literature> GetAllLiteratures()
        {
            return FindAll();
        }
    }
}