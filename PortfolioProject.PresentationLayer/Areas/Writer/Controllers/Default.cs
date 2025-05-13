using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
