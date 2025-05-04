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
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDAL _experienceDal;

        public ExperienceManager(IExperienceDAL experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void TDelete(Experience t)
        {
            _experienceDal.Delete(t);
        }

        public Experience TGetById(int id)
        {
          return _experienceDal.GetByID(id);
        }

        public List<Experience> TGetList()
        {
         return _experienceDal.GetList();
        }

        public void TInsert(Experience t)
        {
         _experienceDal.Insert(t);
        }

        public void TUpdate(Experience t)
        {
            _experienceDal.Update(t);
        }
    }
}
