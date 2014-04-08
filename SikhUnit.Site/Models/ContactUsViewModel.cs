using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class ContactViewModel
    {
        [Required]
        [EmailAddress(ErrorMessage = "The email address is invalid.")]
        [DisplayName("Your Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Your Name (Optional)")]
        public string Name { get; set; }
 
        [Required]
        [DisplayName("Subject")]
        public string Subject { get; set; }
 
        [Required]
        [DisplayName("Message")]
        public string Message { get; set; }

        public string IPAddress { get; set; }
        public DateTimeOffset DateTimeOffset { get; set; }
    }
}