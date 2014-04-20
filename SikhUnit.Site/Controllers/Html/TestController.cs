using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using PagedList;
using SikhUnit.Configuration;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class TestController : Controller
    {
        private readonly IMusicVideoService _musicVideoService;

        public TestController(IMusicVideoService musicVideoService)
        {
            _musicVideoService = musicVideoService;
        }

        public ActionResult VideosOnServer()
        {
            var musicVideos = _musicVideoService.GetAllMusicVideos();
            var musicVideosVmList = Mapper.Map<List<VideoViewModel>>(musicVideos);
            var musicVideosVm = new VideoListViewModel
                                {
                                    List = musicVideosVmList.ToPagedList(1, SiteConfiguration.VideoPageSize),
                                    VideoFolderName = SiteConfiguration.MusicVideosPath
                                };
            
            ViewBag.Title = "Music videos on our server";

            return View("VideosOnServer", musicVideosVm);
        }

        public ActionResult VideosOnYouTube()
        {
            ViewBag.Title = "Music videos on YouTube";

            return View("VideosOnYouTube");
        }
    }
}