using System.Collections.Generic;
using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class Album : INamedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public int AlbumNumber { get; set; }
    }
}