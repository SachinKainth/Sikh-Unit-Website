using System.Collections.Generic;
using SikhUnit.Cache;
using SikhUnit.DataAccess.Context;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.DataAccess.Core;

namespace SikhUnit.DataAccess.Repository
{
    public class OtherSiteRepository : Repository<OtherSite>, IOtherSiteRepository
    {
        public OtherSiteRepository(DatabaseContext context, IDbSetWrapper<OtherSite> dbSetWrapper, IEntityCache entityCache)
            : base(context, dbSetWrapper, entityCache)
        {
        }

        public IEnumerable<OtherSite> GetAllOtherSites()
        {
            return FindAll();
        }
    }
}