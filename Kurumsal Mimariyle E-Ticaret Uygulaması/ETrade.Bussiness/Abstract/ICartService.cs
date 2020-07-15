using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Bussiness.Abstract
{
    public interface ICartService
    {
        void InitializeCart(string userId);
        Cart GetCartByUserId(string userId);
        void AddToCart(string userId, int productId, int quantity);

        void DecreaseQuantity(string userId, int productId, int quantity);

        void DeleteFromCart(string userId, int productId);
        void ClearCart(int cartId);
    }
}
