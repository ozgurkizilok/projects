using System;
using System.Collections.Generic;
using System.Text;
using Ozgur.Northwind.Business.Abstract;
using Ozgur.Northwind.DataAccess.Abstract;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
        }
    }
}
