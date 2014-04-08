using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;

namespace SikhUnit.Site.Controllers.Html
{
    public class ImageController : Controller
    {
        private readonly IImageService _imageService;

        public ImageController(IImageService imageService)
        {
            _imageService = imageService;
        }

        [NonAction]
        public ActionResult Index()
        {
            var images = _imageService.GetAllImages();
            var imagesListVm = new ImageListViewModel { List = Mapper.Map<List<ImageViewModel>>(images) };

            return View(imagesListVm);
        }
    }
}