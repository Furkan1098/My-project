using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Abstract
{
    public interface ICartDal : IRepository<Cart>
    {
        Cart GetByUserId(string userId);
        void DeleteFromCart(int cartId, int productId);
        void ClearCart(int cartId);
    }
}
