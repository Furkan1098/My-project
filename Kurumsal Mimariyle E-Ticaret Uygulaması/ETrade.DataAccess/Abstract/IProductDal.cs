using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    {
        List<Product> GetProductsByCatgeory(string category, int page, int pageSize);

        Product GetProductDetails(int id);
        int GetCountByCategory(string category);
        Product GetByWithCategories(int id);
        void Update(Product entity, int[] categoryIds);
    }
}
