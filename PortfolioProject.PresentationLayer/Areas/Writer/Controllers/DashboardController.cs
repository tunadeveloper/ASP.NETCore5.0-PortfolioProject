using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.DataAccessLayer.Concrete;
using PortfolioProject.EntityLayer.Concrete;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.Surname;

            string api = "799df0672eaf0c89c2e03413273a862a";
            string conntection = "http://api.openweathermap.org/data/2.5/weather?q=erzurum&mode=xml&lang=tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(conntection);
            ViewBag.v5 = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            Context context = new Context();
            ViewBag.v1 = 0;
            ViewBag.v2 = context.Announcements.Count();
            ViewBag.v3 = 0;
            ViewBag.v4 = context.Skills.Count();
            return View();
        }
    }
}
