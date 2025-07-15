using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.DataAccessLayer.Abstract
{
   public interface IGenericDAL<T> where T : class
    {
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetList();
        T GetByID(int id);
        List<T> GetListByFilter(Expression<Func<T, bool>>filter);
    }
}
