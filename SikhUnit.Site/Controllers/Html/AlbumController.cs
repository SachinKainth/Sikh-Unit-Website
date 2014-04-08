using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using PagedList;
using SikhUnit.Configuration;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class AlbumController : Controller
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }

        public ActionResult Index(int page=1)
        {
            var albums = _albumService.GetAllAlbums();
            var albumsVmList = Mapper.Map<List<AlbumViewModel>>(albums);
            var albumsVm = new AlbumListViewModel { List = albumsVmList.ToPagedList(page, SiteConfiguration.AlbumPageSize) };

            return View(albumsVm);
        }
    }
}