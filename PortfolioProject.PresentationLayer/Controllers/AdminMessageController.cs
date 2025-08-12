using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Concrete;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Linq;

namespace PortfolioProject.PresentationLayer.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;
      private readonly Context _context;

        public AdminMessageController(IWriterMessageService writerMessageService, Context context)
        {
            _writerMessageService = writerMessageService;
            _context = context;
        }

        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = _writerMessageService.GetListReceiverMessage(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = _writerMessageService.GetListSendMessage(p);
            return View(values);
        }

        [HttpGet("AdminMessage/GetReceiverMessageDetails/{id}")]
        public IActionResult GetReceiverMessageDetails(int id)
        {
            var message = _writerMessageService.TGetById(id);
            if (message == null)
                return NotFound();

            return Json(new
            {
                senderName = message.SenderName,
                senderEmail = message.Sender,
                date = message.Date.ToString("dd MMM yyyy HH:mm"),
                content = message.Content
            });
        }
        [HttpGet("AdminMessage/GetSenderMessageDetails/{id}")]
        public IActionResult GetSenderMessageDetails(int id)
        {
            var message = _writerMessageService.TGetById(id);
            if (message == null)
                return NotFound();

            return Json(new
            {
                receiverName = message.ReceiverName,
                receiverEmail = message.Receiver,
                date = message.Date.ToString("dd MMM yyyy HH:mm"),
                content = message.Content
            });
        }


        public IActionResult DeleteMessage(int id, string source)
        {
            var values = _writerMessageService.TGetById(id);
            if (values == null)
                return NotFound();

            _writerMessageService.TDelete(values);

            return source switch
            {
                "sender" => RedirectToAction("SenderMessageList"),
                "receiver" => RedirectToAction("ReceiverMessageList"),
                _ => RedirectToAction("ReceiverMessageList") 
            };
        }

        public IActionResult CreateMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(WriterMessage writerMessage)
        {
            writerMessage.Sender = "admin@gmail.com";
            writerMessage.SenderName = "Admin";
            writerMessage.Date = DateTime.Now;
            writerMessage.ReceiverName= _context.Users.Where(x => x.Email == writerMessage.Receiver).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            _writerMessageService.TInsert(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
    }
}
