using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class Song : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }
        public int TrackNumber { get; set; }
    }
}