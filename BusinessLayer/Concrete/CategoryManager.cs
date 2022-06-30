using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Tadd(Category p)
        {
            _categoryDal.Insert(p);
        }

        public void TDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public Category TGetByID(int id)
        {
            return _categoryDal.GetByID(id);
        }

        public List<Category> TGetlist()
        {
            return _categoryDal.GetList();
        }

        public void TUpdate(Category p)
        {
            _categoryDal.Update(p);
        }
    }
}
