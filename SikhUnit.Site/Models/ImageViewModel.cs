using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class ImageViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}