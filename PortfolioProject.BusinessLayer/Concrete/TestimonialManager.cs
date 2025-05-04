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
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDAL _testimonialDal;

        public TestimonialManager(ITestimonialDAL testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimonialDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetByID(id);
        }

        public List<Testimonial> TGetList()
        {
           return _testimonialDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
           _testimonialDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimonialDal.Update(t);
        }
    }
}
