using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDAL _aboutDAL;

        public AboutManager(IAboutDAL aboutDAL)
        {
            _aboutDAL = aboutDAL;
        }

        public void TDelete(About t)
        {
            _aboutDAL.Delete(t);
        }

        public About TGetById(int id)
        {
           return _aboutDAL.GetByID(id);
        }

        public List<About> TGetList()
        {
            return _aboutDAL.GetList();
        }

        public List<About> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(About t)
        {
            _aboutDAL.Insert(t);
        }


        public void TUpdate(About t)
        {
           _aboutDAL.Update(t);
        }
    }
}
