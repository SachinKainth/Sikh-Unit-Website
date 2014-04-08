using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SikhUnit.Site.Models
{
    public class SongListViewModel
    {
        public List<SongViewModel> List { get; set; }

        [Required]
        public string AlbumName { get; set; }
       
        [Required]
        public int AlbumId { get; set; }
    }
}