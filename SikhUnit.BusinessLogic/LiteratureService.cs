using System.Collections.Generic;
using System.Linq;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Repository;
using SikhUnit.Domain.Interface.Service;

namespace SikhUnit.BusinessLogic
{
    public class LiteratureService : ILiteratureService
    {
        private readonly ILiteratureRepository _literatureRepository;

        public LiteratureService(ILiteratureRepository literatureRepository)
        {
            _literatureRepository = literatureRepository;
        }

        public List<Literature> GetAllLiteratures()
        {
            return _literatureRepository.GetAllLiteratures().ToList();
        }
    }
}