using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using System.Linq;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private readonly ISkillService _skillService;
        private readonly IServiceService _serviceService;
        private readonly IPortfolioService _portfolioService;
        private readonly IExperienceService _experienceService;

        public DashboardController(ISkillService skillService, IServiceService serviceService, IPortfolioService portfolioService, IExperienceService experienceService)
        {
            _skillService = skillService;
            _serviceService = serviceService;
            _portfolioService = portfolioService;
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            ViewBag.v1= _portfolioService.TGetList().Count();
            ViewBag.v2= _serviceService.TGetList().Count();
            ViewBag.v3= _skillService.TGetList().Count();
            ViewBag.v4= _experienceService.TGetList().Count();
            return View();
        }

        [HttpGet]
        public IActionResult SkillChartData()
        {
            var values = _skillService.TGetList().Select(x=>new
            {
                title = x.Title,
                value = x.Value,
            }).ToList();

            return Json(values);
        }

        
    }
}
