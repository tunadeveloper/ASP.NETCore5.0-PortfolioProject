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
    public class EfTestimonialDAL : GenericRepository<Testimonial>, ITestimonialDAL
    {
        public EfTestimonialDAL(Context context) : base(context)
        {
        }
    }
}
