namespace SikhUnit.Site.Models
{
    public class VideoListViewModel
    {
        public PagedList.IPagedList<VideoViewModel> List { get; set; }
        public string VideoFolderName { get; set; }
    }
}