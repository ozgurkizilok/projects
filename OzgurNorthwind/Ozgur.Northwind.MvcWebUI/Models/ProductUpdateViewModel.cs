﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.MvcWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}
