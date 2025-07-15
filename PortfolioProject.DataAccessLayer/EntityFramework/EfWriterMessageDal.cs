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
    public class EfWriterMessageDal : GenericRepository<WriterMessage>, IWriterMessageDal
    {
        public EfWriterMessageDal(Context context) : base(context)
        {
        }
    }
}
