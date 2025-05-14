using System.ComponentModel.DataAnnotations;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string ImageUrl { get; set; }
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor!")]
        public string ConfirmPassword { get; set; }
        public string Mail { get; set; }
    }
}
