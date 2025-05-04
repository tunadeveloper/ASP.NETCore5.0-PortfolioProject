using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;

namespace PortfolioProject.PresentationLayer.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        private readonly ISkillService _skillService;

        public SkillList(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_skillService.TGetList());
        }
    }
}
