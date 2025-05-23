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

    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void TDelete(User t)
        {
           _userDal.Delete(t);
        }

        public User TGetById(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TInsert(User t)
        {_userDal.Insert(t);
        }

        public void TUpdate(User t)
        {
           _userDal.Update(t);
        }
    }
}
