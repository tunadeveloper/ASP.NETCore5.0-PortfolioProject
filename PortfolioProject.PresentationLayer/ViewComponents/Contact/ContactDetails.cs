using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;

namespace PortfolioProject.PresentationLayer.ViewComponents.Contact
{
    public class ContactDetails:ViewComponent
    {
        private readonly IContactService _contactService;

        public ContactDetails(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IViewComponentResult Invoke()
        {
            return View(_contactService.TGetList());
        }
    }
}
