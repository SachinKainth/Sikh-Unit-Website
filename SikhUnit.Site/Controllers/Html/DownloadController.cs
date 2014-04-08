using System.Web;
using System.Web.Mvc;
using SikhUnit.Configuration;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.ActionResults;

namespace SikhUnit.Site.Controllers.Html
{
    public class DownloadController : Controller
    {
        private readonly IAlbumService _albumService;

        public DownloadController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public ActionResult Download(int albumId)
        {
            var album = _albumService.GetAlbum(albumId);

            if (album == null)
                throw new HttpException(404, "Album with id " + albumId + " does not exist.");

            return new ZipResult(Server.MapPath(SiteConfiguration.ContentPath + SiteConfiguration.AlbumsPath + album.Name)) { FileName = album.Name };
        }
    }
}