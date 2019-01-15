using System;
using System.Collections.Generic;
using System.Text;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }


}
