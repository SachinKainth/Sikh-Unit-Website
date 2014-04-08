using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using PagedList;
using SikhUnit.Configuration;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class MusicVideoController : Controller
    {
        private readonly IMusicVideoService _musicVideoService;

        public MusicVideoController(IMusicVideoService musicVideoService)
        {
            _musicVideoService = musicVideoService;
        }

        [NonAction]
        public ActionResult Index(int page=1)
        {
            var musicVideos = _musicVideoService.GetAllMusicVideos();
            var musicVideosVmList = Mapper.Map<List<VideoViewModel>>(musicVideos);
            var musicVideosVm = new VideoListViewModel
                                {
                                    List = musicVideosVmList.ToPagedList(page, SiteConfiguration.VideoPageSize),
                                    VideoFolderName = SiteConfiguration.MusicVideosPath
                                };
            
            ViewBag.Title = "Music Videos";

            return View("Videos", musicVideosVm);
        }
    }
}