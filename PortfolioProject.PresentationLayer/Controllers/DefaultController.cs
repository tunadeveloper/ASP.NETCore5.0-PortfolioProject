using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        private readonly IMessageService _messageService;
        private readonly IFeatureService _featureService;
        private readonly ISocialMediaService _socialMediaService;

        public DefaultController(IMessageService messageService, IAboutService aboutService, ISocialMediaService socialMediaService, IFeatureService featureService)
        {
            _messageService = messageService;
            _socialMediaService = socialMediaService;
            _featureService = featureService;
        }

        public IActionResult Index()
        {
            var viewModel = new Models.FeatureAndSocialMediaViewModel
            {
                SocialMedias = _socialMediaService.TGetList(),
                Features = _featureService.TGetList()
            };
            return View(viewModel);
        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message.Status = true;
            message.Date = DateTime.Now;
            _messageService.TInsert(message);
            return RedirectToAction("Index");
        }
    }
}
