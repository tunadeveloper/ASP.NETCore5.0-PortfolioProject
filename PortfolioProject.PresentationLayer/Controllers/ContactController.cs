using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;

namespace PortfolioProject.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IMessageService _messageService;

        public ContactController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Index()
        {
            var values = _messageService.TGetList();
            return View(values);
        }

        public IActionResult DeleteMessage(int id)
        {
            var values = _messageService.TGetById(id);
            _messageService.TDelete(values);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult GetMessageById(int id)
        {
            var message = _messageService.TGetById(id);
            if (message == null)
                return NotFound();

            return Json(new
            {
                name = message.Name,
                mail = message.Mail,
                date = message.Date.ToString("dd MMM yyyy HH:mm"),
                content = message.Content
            });
        }
    }
}
