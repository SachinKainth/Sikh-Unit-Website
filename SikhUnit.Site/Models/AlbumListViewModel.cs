using PagedList;

namespace SikhUnit.Site.Models
{
    public class AlbumListViewModel
    {
        public IPagedList<AlbumViewModel> List { get; set; }
    }
}