using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.PresentationLayer.Controllers
{
    public class SkillController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
