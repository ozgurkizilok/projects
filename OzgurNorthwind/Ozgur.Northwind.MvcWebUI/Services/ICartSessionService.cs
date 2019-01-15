using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ozgur.Northwind.Entities.Concrete;

namespace Ozgur.Northwind.MvcWebUI.Services
{
    public interface ICartSessionService
    {
        Cart GetCart();
        void SetCart(Cart cart);
    }
}
