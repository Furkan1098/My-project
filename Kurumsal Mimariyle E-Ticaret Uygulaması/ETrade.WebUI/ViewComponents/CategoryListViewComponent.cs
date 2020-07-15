using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETrade.Bussiness.Abstract;
using ETrade.Entities.Entities;

namespace ETrade.WebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent    
    {
        private ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            CategoryListViewModel model = new CategoryListViewModel
            {
                Categories = _categoryService.GetAll(),
                SelectedCategory = RouteData.Values["category"]?.ToString()
            };
            return View(model);
        }
    }
}
