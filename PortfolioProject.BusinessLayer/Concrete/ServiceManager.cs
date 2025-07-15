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
    public class ServiceManager : IServiceService
    {
        private readonly IServiceDAL _serviceDal;

        public ServiceManager(IServiceDAL serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void TDelete(Service t)
        {
            _serviceDal.Delete(t);
        }

        public Service TGetById(int id)
        {
           return _serviceDal.GetByID(id);
        }

        public List<Service> TGetList()
        {
            return _serviceDal.GetList();
        }

        public List<Service> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Service t)
        {
            _serviceDal.Insert(t);
        }

        public void TUpdate(Service t)
        {
            _serviceDal.Update(t);
        }
    }
}
