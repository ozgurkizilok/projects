using System;
using System.Collections.Generic;
using System.Text;
using Ozgur.Core.DataAccess;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}
