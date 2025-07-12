using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.EntityLayer.Concrete;
using PortfolioProject.PresentationLayer.Areas.Writer.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureURL = values.ImageUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel u)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (u.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(u.Picture.FileName);
                var imageName = Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/UserImage/" + imageName;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await u.Picture.CopyToAsync(stream);
               user.ImageUrl = imageName;
            }
            user.Name = u.Name;
            user.Surname = u.Surname;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Default", "Writer");
            }
            return View();
        }
    }
}
