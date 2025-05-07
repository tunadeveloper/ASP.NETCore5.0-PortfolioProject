using Microsoft.AspNetCore.Mvc;
using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;

namespace PortfolioProject.PresentationLayer.ViewComponents.Contact
{
    public class SendMessage:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }

    }
}
