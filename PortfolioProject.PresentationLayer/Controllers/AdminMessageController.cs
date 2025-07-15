using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;

namespace PortfolioProject.PresentationLayer.Controllers
{
    public class AdminMessageController : Controller
    {
        private readonly IWriterMessageService _writerMessageService;

        public AdminMessageController(IWriterMessageService writerMessageService)
        {
            _writerMessageService = writerMessageService;
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

        [HttpGet("AdminMessage/GetMessageDetails/{id}")]
        public IActionResult GetMessageDetails(int id)
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
            _writerMessageService.TInsert(writerMessage);
            return RedirectToAction("SenderMessageList");
        }
    }
}
