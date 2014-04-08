using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class OtherSite : IEntity
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }
    }
}