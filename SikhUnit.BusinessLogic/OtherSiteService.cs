using System.Collections.Generic;
using System.Linq;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic
{
    public class OtherSiteService : IOtherSiteService
    {
        private readonly IOtherSiteRepository _otherSiteRepository;

        public OtherSiteService(IOtherSiteRepository otherSiteRepository)
        {
            _otherSiteRepository = otherSiteRepository;
        }

        public List<OtherSite> GetAllOtherSites()
        {
            return _otherSiteRepository.GetAllOtherSites().ToList();
        }
    }
}