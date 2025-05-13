using Microsoft.EntityFrameworkCore;
using PortfolioProject.DataAccessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Concrete;
using PortfolioProject.DataAccessLayer.Repository;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccessLayer.EntityFramework
{
   public class EfUserMessageDal:GenericRepository<UserMessage>, IUserMessageDal
    {
        public EfUserMessageDal(Context context) : base(context)
        {
        }

        public List<UserMessage> GetUserMessageWithUser()
        {
           using (var context = new Context())
            {
                return context.UserMessages.Include(x=> x.User).ToList();
            }
        }
    }
}
