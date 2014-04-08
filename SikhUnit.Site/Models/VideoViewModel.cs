using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class VideoViewModel
    {
        [Required]
        public string Name { get; set; }
        public string ExtensionLessName { get; set; }
    }
}