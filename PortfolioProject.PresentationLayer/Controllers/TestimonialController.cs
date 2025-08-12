using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly ITestimonialService _testimonialService;

        public TestimonialController(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IActionResult Index()
        {
            var values = _testimonialService.TGetList();
            return View(values);
        }

        public IActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TInsert(testimonial);
            TempData["SuccessMessage"] = "Referans başarıyla eklendi!";
            return RedirectToAction("Index");
        }

        public IActionResult UpdateTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateTestimonial(Testimonial testimonial)
        {
            _testimonialService.TUpdate(testimonial);
            TempData["SuccessMessage"] = "Referans başarıyla güncellendi!";
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTestimonial(int id)
        {
            var values = _testimonialService.TGetById(id);
            _testimonialService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
