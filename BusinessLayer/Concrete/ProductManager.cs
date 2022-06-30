using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Tadd(Product p)
        {
            _productDal.Insert(p);
        }

        public void TDelete(Product p)
        {
            _productDal.Delete(p);
        }

        public Product TGetByID(int id)
        {
            return _productDal.GetByID(id);
        }

        public List<Product> TGetlist()
        {
            return _productDal.GetList();
        }

        public void TUpdate(Product p)
        {
            _productDal.Update(p);
        }
    }
}
