using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class LiteratureViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string DisplayName { get; set; }
    }
}