using ETrade.Entities.Entities;
using System.Collections.Generic;

namespace ETrade.WebUI
{
    public class ProductDetailsViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}