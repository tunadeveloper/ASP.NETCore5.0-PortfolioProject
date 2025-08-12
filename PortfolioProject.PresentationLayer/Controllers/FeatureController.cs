using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class FeatureController : Controller
    {
        private readonly IFeatureService _featureService;

        public FeatureController(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IActionResult UpdateFeature()
        {
            var values = _featureService.TGetById(1);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            _featureService.TUpdate(feature);
            return RedirectToAction("Index", "Default");
        }
    }
}
