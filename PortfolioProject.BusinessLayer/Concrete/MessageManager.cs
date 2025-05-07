using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDAL _messageDal;

        public MessageManager(IMessageDAL messageDal)
        {
            _messageDal = messageDal;
        }

        public void TDelete(Message t)
        {
           _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
           return _messageDal.GetByID(id);
        }

        public List<Message> TGetList()
        {
           return _messageDal.GetList();
        }

        public void TInsert(Message t)
        {
          _messageDal.Insert(t);
        }

        public void TUpdate(Message t)
        {
           _messageDal.Update(t);
        }
    }
}
