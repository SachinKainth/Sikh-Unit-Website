using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class OtherSiteViewModel
    {
        [Required]
        public string DisplayName { get; set; }

        [Required]
        public string Url { get; set; }
    }
}