using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> 
    {
        void Tadd(T p);
        void TUpdate(T p);
        void TDelete(T p);
        List<T> TGetlist();
        T TGetByID(int id);
    }
}
