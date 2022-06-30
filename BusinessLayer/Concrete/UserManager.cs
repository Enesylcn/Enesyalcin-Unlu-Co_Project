using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Tadd(User p)
        {
            _userDal.Insert(p);
        }

        public void TDelete(User p)
        {
            _userDal.Delete(p);
        }

        public User TGetByID(int id)
        {
          return  _userDal.GetByID(id);
        }

        public List<User> TGetlist()
        {
            return _userDal.GetList();
        }

        public void TUpdate(User p)
        {
            _userDal.Update(p);
        }
    }
}
