using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;
using PortfolioProject.DataAccessLayer.Concrete;
using PortfolioProject.DataAccessLayer.EntityFramework;
using PortfolioProject.EntityLayer.Concrete;
using PortfolioProject.PresentationLayer.Areas.Writer.Models;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
       private readonly IAnnouncementService _announcementService;

        public DefaultController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public IActionResult Index()
        {
            var values = _announcementService.TGetList();
            return View(values);
        }

        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = _announcementService.TGetById(id);
            return View(announcement);
        }

        
    }
}
