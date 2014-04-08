using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class MusicVideo : IVideo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}