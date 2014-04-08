using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class AlbumViewModel
    {
        [Required]
        public string Name { get; set; }
        public int Id { get; set; }
    }
}