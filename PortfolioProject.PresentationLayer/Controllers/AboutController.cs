using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System.Resources;

namespace PortfolioProject.PresentationLayer.Controllers
{
    public class AboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult UpdateAbout()
        {
            var values = _aboutService.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
                _aboutService.TUpdate(about);
                return RedirectToAction("Index", "Default");
        }
    }
}
