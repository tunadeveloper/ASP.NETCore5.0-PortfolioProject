using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class SocialMediaController : Controller
    {
        private readonly ISocialMediaService _socialMediaService;

        public SocialMediaController(ISocialMediaService socialMediaService)
        {
            _socialMediaService = socialMediaService;
        }

        public IActionResult Index()
        {
            var values = _socialMediaService.TGetList();
            return View(values);
        }

        public IActionResult CreateSocialMedia() => View();
        [HttpPost]
        public IActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TInsert(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSocialMedia(int id)
        {
            var values = _socialMediaService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            _socialMediaService.TUpdate(socialMedia);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSocialMedia(int id)
        {
            var values = _socialMediaService.TGetById(id);
            _socialMediaService.TDelete(values);
            return RedirectToAction("Index");

        }
    }
}
