using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.EntityLayer.Concrete;
using PortfolioProject.PresentationLayer.Areas.Writer.Models;
using System.Threading.Tasks;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RegisterController : Controller
    {

        private readonly UserManager<WriterUser> _userManager;

        public RegisterController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel u)
        {
            if (ModelState.IsValid)
            {
                WriterUser newUser = new WriterUser()
                {
                    Name = u.Name,
                    Surname = u.Surname,
                    UserName = u.UserName,
                    Email = u.Mail,
                    ImageUrl = u.ImageUrl
                };
                if (u.ConfirmPassword == u.Password)
                {
                    var result = await _userManager.CreateAsync(newUser, u.Password);



                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Login", "Writer" );
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }
                }
            }
            return View();
        }
    }
}
