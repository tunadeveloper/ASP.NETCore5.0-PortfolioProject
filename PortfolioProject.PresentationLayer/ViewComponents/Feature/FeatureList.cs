using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;
using PortfolioProject.DataAccessLayer.EntityFramework;

namespace PortfolioProject.PresentationLayer.ViewComponents.Feature

{
    public class FeatureList : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public FeatureList(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_featureService.TGetList());
        }
    }
}
