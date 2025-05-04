﻿using PortfolioProject.BusinessLayer.Abstract;
using PortfolioProject.DataAccessLayer.Abstract;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDAL _contactDAL;

        public ContactManager(IContactDAL contactDAL)
        {
            _contactDAL = contactDAL;
        }

        public void TDelete(Contact t)
        {
           _contactDAL.Delete(t);
        }

        public Contact TGetById(int id)
        {
           return _contactDAL.GetByID(id);
        }

        public List<Contact> TGetList()
        {
           return _contactDAL.GetList();
        }

        public void TInsert(Contact t)
        {
           _contactDAL.Insert(t);
        }

        public void TUpdate(Contact t)
        {
           _contactDAL.Update(t);
        }
    }
}
