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
    public class UserMessageManager : IUserMessageService
    {
        private readonly IUserMessageDal _userMessageDal;

        public UserMessageManager(IUserMessageDal userMessageDal)
        {
            _userMessageDal = userMessageDal;
        }

        public List<UserMessage> GetUserMessageWithUserSeervice()
        {
            return _userMessageDal.GetUserMessageWithUser();

        }

        public void TDelete(UserMessage t)
        {
            _userMessageDal.Delete(t);
        }

        public UserMessage TGetById(int id)
        {
           return _userMessageDal.GetByID(id);
        }

        public List<UserMessage> TGetList()
        {
            return _userMessageDal.GetList();
        }

        public void TInsert(UserMessage t)
        {
            _userMessageDal.Insert(t);
        }

        public void TUpdate(UserMessage t)
        {
           _userMessageDal.Update(t);
        }
    }
}
