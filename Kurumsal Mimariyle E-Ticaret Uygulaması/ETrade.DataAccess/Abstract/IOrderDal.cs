using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Abstract
{
    public interface IOrderDal : IRepository<Order>
    {
        List<Order> GetOrders(string userId);
    }
}
