using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.BusinessLayer.Concrete;
using PortfolioProject.DataAccessLayer.Concrete;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioProject.PresentationLayer.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class MessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;
        private readonly UserManager<WriterUser> _userManager;

        public MessageController(IWriterMessageService writerMessageService, UserManager<WriterUser> userManager)
        {
            _writerMessageService = writerMessageService;
            _userManager = userManager;
        }

        public async Task<IActionResult> ReceiverMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _writerMessageService.GetListReceiverMessage(p);
            return View(messageList);
        }

        public async Task<IActionResult> SenderMessage(string p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            p = values.Email;
            var messageList = _writerMessageService.GetListSendMessage(p);
            return View(messageList);
        }

        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(WriterMessage writerMessage)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            writerMessage.Date = DateTime.Now;
            writerMessage.Sender = values.Email;
            writerMessage.SenderName = values.Name + " " + values.Surname;
            Context context = new Context();
            writerMessage.ReceiverName = context.Users.Where(x => x.Email == writerMessage.Receiver).Select(y => y.Name + " " + y.Surname).FirstOrDefault();
            _writerMessageService.TInsert(writerMessage);
            return RedirectToAction("SenderMessage", "Message", new { area = "Writer" });

        }
    }
}

