using System;
using System.Web.Mvc;
using AutoMapper;
using SikhUnit.Domain.Entity;
using SikhUnit.Domain.Interface.Service;
using SikhUnit.Site.Models;
using Recaptcha.Web;
using Recaptcha.Web.Mvc;

namespace SikhUnit.Site.Controllers.Html
{
    public class ContactUsController : Controller
    {
        private readonly IEmailService _emailService;
        private readonly IContactService _contactService;

        public ContactUsController(IEmailService emailService, IContactService contactService)
        {
            _emailService = emailService;
            _contactService = contactService;
        }

        [HttpGet]
        public ActionResult Contact()
        {
            var model = new ContactViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Contact(ContactViewModel model)
        {
            ValidateCaptcha();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.DateTimeOffset = DateTimeOffset.UtcNow;
            model.IPAddress = Request.UserHostAddress;

            var contact = Mapper.Map<Contact>(model);

            _contactService.SaveContact(contact);
            _emailService.Send(contact);
 
            return RedirectToAction("ContactConfirm");
        }

        public ActionResult ContactConfirm()
        {
            return View();
        }

        private void ValidateCaptcha()
        {
            RecaptchaVerificationHelper recaptchaHelper = this.GetRecaptchaVerificationHelper();

            if (string.IsNullOrEmpty(recaptchaHelper.Response))
            {
     
                ModelState.AddModelError("", "Captcha answer cannot be empty.");
                return;
            }

            RecaptchaVerificationResult recaptchaResult = recaptchaHelper.VerifyRecaptchaResponse();

            if (recaptchaResult != RecaptchaVerificationResult.Success)
            {
                ModelState.AddModelError("", "Incorrect captcha answer.");
            }
        }
    }
}