using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Bussiness.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetById(int id);
        Product GetProductDetails(int id);
        List<Product> GetAll();
        List<Product> GetProductByCategory(string category, int page, int pageSize);
        bool Create(Product entity);
        void Update(Product entity);
        void Update(Product entity, int[] categoryIds);
        void Delete(Product entity);
        int GetCountByCategory(string category);
        Product GetByWithCategories(int id);
    }
}
