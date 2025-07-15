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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDAL _skillDal;

        public SkillManager(ISkillDAL skillDal)
        {
            _skillDal = skillDal;
        }

        public void TDelete(Skill t)
        {
            _skillDal.Delete(t);
        }

        public Skill TGetById(int id)
        {
          return _skillDal.GetByID(id);
        }

        public List<Skill> TGetList()
        {
            return _skillDal.GetList();
        }

        public List<Skill> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void TUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
