using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class SongController : Controller
    {
        private readonly ISongService _songService;
        private readonly IAlbumService _albumService;

        public SongController(ISongService songService, IAlbumService albumService)
        {
            _songService = songService;
            _albumService = albumService;
        }

        public ActionResult Index(int albumId)
        {
            var album = _albumService.GetAlbum(albumId);

            if(album == null)
                throw new HttpException(404, "Album with id " + albumId + " does not exist.");

            var songs = _songService.GetAllSongsForAlbum(albumId);

            var songsListVm = new SongListViewModel { List = Mapper.Map<List<SongViewModel>>(songs), AlbumName = album.Name, AlbumId = album.Id };

            return View(songsListVm);
        }
    }
}