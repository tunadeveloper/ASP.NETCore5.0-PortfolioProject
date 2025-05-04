using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;

namespace PortfolioProject.PresentationLayer.ViewComponents.Service
{
    public class ServiceList:ViewComponent
    {
        private readonly IServiceService _serviceService;

        public ServiceList(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_serviceService.TGetList());
        }
    }
}
