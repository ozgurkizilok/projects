using System;
using System.Collections.Generic;
using System.Text;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();
    }
}
