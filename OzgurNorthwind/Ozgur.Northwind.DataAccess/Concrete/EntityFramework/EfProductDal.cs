using System;
using System.Collections.Generic;
using System.Text;
using Ozgur.Core.DataAccess.EntityFramework;
using Ozgur.Northwind.DataAccess.Abstract;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
