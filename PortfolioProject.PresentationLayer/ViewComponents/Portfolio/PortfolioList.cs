using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;

namespace PortfolioProject.PresentationLayer.ViewComponents.Portfolio
{
    public class PortfolioList:ViewComponent
    {
        private readonly IPortfolioService _portfolioService;

        public PortfolioList(IPortfolioService portfolioService)
        {
            _portfolioService = portfolioService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_portfolioService.TGetList());
        }
    }
}
