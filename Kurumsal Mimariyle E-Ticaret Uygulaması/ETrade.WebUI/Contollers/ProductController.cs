using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.Bussiness.Abstract;
using ETrade.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ETrade.WebUI.Contollers
{
    public class ProductController : Controller
    {
        private IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Details(int? id)
        {
            if (id== null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails((int)id);

            if (product==null)
            {
                return NotFound();
            }
            ProductDetailsViewModel model = new ProductDetailsViewModel
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            };
            return View(model);
            
        }
        public IActionResult List(string category, int page=1)
        {
            const int pageSize = 3;
            ProductListViewModel model = new ProductListViewModel
            {
                Products = _productService.GetProductByCategory(category, page, pageSize),
                PageInfo=new PageInfo
                {
                    TotalItems=_productService.GetCountByCategory(category),
                    CurrentPage=page,
                    ItemsPerPage= pageSize,
                    CurrentCategory=category

                }
            };
            return View(model);
        }
    }
}
