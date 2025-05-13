using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccessLayer.Abstract
{
    public interface IUserMessageDal:IGenericDAL<UserMessage>
    {
        public List<UserMessage> GetUserMessageWithUser();
    }
}
