using SikhUnit.Domain.Interface.Core;

namespace SikhUnit.Domain.Entity
{
    public class TalkVideo : IVideo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}