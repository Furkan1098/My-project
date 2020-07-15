using ETrade.Entities.Entities;
using System.Collections.Generic;

namespace ETrade.WebUI
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }

        public string SelectedCategory { get; set; }
    }
}