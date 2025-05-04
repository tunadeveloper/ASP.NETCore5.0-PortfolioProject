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
   
    public class FeatureManager : IFeatureService
    {
        private readonly IFeatureDAL _featureDAL;

        public FeatureManager(IFeatureDAL featureDAL)
        {
            _featureDAL = featureDAL;
        }

        public void TDelete(Feature t)
        {
           _featureDAL.Delete(t);
        }

        public Feature TGetById(int id)
        {
            return _featureDAL.GetByID(id);
        }

        public List<Feature> TGetList()
        {
            return _featureDAL.GetList();
        }

        public void TInsert(Feature t)
        {
         _featureDAL.Insert(t);
        }

        public void TUpdate(Feature t)
        {
          _featureDAL.Update(t);
        }
    }
}
