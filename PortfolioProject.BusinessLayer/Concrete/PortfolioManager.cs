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
    public class PortfolioManager : IPortfolioService
    {
        private readonly IPortfolioDAL _portfolioDal;

        public PortfolioManager(IPortfolioDAL portfolioDal)
        {
            _portfolioDal = portfolioDal;
        }

        public void TDelete(Portfolio t)
        {
          _portfolioDal.Delete(t);
        }

        public Portfolio TGetById(int id)
        {
            return _portfolioDal.GetByID(id);
        }

        public List<Portfolio> TGetList()
        {
           return _portfolioDal.GetList();
        }

        public List<Portfolio> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Portfolio t)
        {
            _portfolioDal.Insert(t);
        }

        public void TUpdate(Portfolio t)
        {
          _portfolioDal.Update(t);
        }
    }
}
