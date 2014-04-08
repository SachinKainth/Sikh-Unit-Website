using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class LiteratureController : Controller
    {
        private readonly ILiteratureService _literatureService;

        public LiteratureController(ILiteratureService literatureService)
        {
            _literatureService = literatureService;
        }

        public ActionResult Index()
        {
            var literatures = _literatureService.GetAllLiteratures();
            var literatureListVm = new LiteratureListViewModel { List = Mapper.Map<List<LiteratureViewModel>>(literatures) };

            return View(literatureListVm);
        }
    }
}