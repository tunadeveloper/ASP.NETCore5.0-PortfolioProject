using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.PresentationLayer.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
