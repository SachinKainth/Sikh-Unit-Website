using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class Literature : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string ImageName { get; set; }
    }
}