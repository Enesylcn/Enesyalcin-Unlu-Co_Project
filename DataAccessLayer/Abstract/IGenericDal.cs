using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T p);
        void Delete(T p);
        void Update(T p);
        List<T> GetList();

        T GetByID(int id);
    }
}
