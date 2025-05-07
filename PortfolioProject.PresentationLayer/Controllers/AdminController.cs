using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.PresentationLayer.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
    }
}
