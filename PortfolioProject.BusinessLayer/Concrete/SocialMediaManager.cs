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
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDAL _socialMediaDAL;

        public SocialMediaManager(ISocialMediaDAL socialMediaDAL)
        {
            _socialMediaDAL = socialMediaDAL;
        }

        public void TDelete(SocialMedia t)
        {
           _socialMediaDAL.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
          return _socialMediaDAL.GetByID(id);
        }

        public List<SocialMedia> TGetList()
        {
           return _socialMediaDAL.GetList();
        }

        public List<SocialMedia> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(SocialMedia t)
        {
        _socialMediaDAL.Insert(t);
        }

        public void TUpdate(SocialMedia t)
        {
  _socialMediaDAL.Update(t);
        }
    }
}
