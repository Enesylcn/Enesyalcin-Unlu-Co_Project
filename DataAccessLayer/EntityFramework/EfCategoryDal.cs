using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
    }
}
