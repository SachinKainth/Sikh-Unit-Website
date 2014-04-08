using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class OtherSiteController : Controller
    {
        private readonly IOtherSiteService _otherSiteService;

        public OtherSiteController(IOtherSiteService otherSiteService)
        {
            _otherSiteService = otherSiteService;
        }

        public ActionResult Index()
        {
            var otherSites = _otherSiteService.GetAllOtherSites();
            var otherSiteListVm = new OtherSiteListViewModel { List = Mapper.Map<List<OtherSiteViewModel>>(otherSites) };

            return View(otherSiteListVm);
        }
    }
}