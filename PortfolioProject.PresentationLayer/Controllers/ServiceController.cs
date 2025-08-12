using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values = _serviceService.TGetList();
            return View(values);
        }
        public IActionResult UpdateService(int id)
        {
            var values = _serviceService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
         _serviceService.TUpdate(service);
            return RedirectToAction("Index", "Default");
        }

        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetById(id);
            _serviceService.TDelete(value);
            return RedirectToAction("Index");
        }
        public IActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateService(Service service)
        {
            _serviceService.TInsert(service);
            return RedirectToAction("Index", "Default");
        }
    }
}
