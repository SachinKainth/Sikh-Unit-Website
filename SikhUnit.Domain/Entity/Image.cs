using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class Image : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}