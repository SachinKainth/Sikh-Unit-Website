using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using PagedList;
using SikhUnit.Configuration;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class TalkVideoController : Controller
    {
        private readonly ITalkVideoService _talkVideoService;

        public TalkVideoController(ITalkVideoService talkVideoService)
        {
            _talkVideoService = talkVideoService;
        }

        [NonAction]
        public ActionResult Index(int page=1)
        {
            var talkVideos = _talkVideoService.GetAllTalkVideos();
            var talkVideosVmList = Mapper.Map<List<VideoViewModel>>(talkVideos);
            var talkVideosVm = new VideoListViewModel
            {
                List = talkVideosVmList.ToPagedList(page, SiteConfiguration.VideoPageSize),
                VideoFolderName = SiteConfiguration.TalkVideosPath
            };

            ViewBag.Title = "Talk Videos";

            return View("Videos", talkVideosVm);
        }
    }
}