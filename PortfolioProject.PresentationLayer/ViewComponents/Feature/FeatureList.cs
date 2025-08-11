using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;
using PortfolioProject.DataAccessLayer.EntityFramework;
using PortfolioProject.PresentationLayer.Models;

namespace PortfolioProject.PresentationLayer.ViewComponents.Feature

{
    public class FeatureList : ViewComponent
    {
        private readonly IFeatureService _featureService;
        private readonly ISocialMediaService _socialMediaService;

        public FeatureList(IFeatureService featureService, ISocialMediaService socialMediaService)
        {
            _featureService = featureService;
            _socialMediaService = socialMediaService;
        }

        public IViewComponentResult Invoke()
        {
            var model = new FeatureAndSocialMediaViewModel
            {
                Features = _featureService.TGetList(),
                SocialMedias = _socialMediaService.TGetList()
            };

            return View(model);
        }
    }
}
