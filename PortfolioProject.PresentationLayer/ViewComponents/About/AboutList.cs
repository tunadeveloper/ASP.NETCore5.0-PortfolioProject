using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PortfolioProject.BusinessLayer.Abstract;

namespace PortfolioProject.PresentationLayer.ViewComponents.About
{
    public class AboutList:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public AboutList(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_aboutService.TGetList());
        }
    }
}
