using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
