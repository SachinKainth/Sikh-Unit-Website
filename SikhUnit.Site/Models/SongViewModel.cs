using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class SongViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}