using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;

namespace PortfolioProject.PresentationLayer.ViewComponents.Experience
{
    public class ExperienceList:ViewComponent
    {
        private readonly IExperienceService _experienceService;

        public ExperienceList(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_experienceService.TGetList());
        }
    }
}
