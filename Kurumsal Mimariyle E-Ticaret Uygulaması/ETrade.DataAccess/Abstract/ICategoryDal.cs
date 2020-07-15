using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Abstract
{
    public interface ICategoryDal : IRepository<Category>
    {
        Category GetByIdWithProducts(int id);
        void DeleteFromCategory(int categoryId, int productId);
    }

}
