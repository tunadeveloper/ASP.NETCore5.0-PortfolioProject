using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;

namespace PortfolioProject.PresentationLayer.ViewComponents.Testimonial
{
    public class TestimonialList:ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialList(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_testimonialService.TGetList());
        }
    }
}
