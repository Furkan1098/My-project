using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.WebUI.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Kategori adı alanını doldurmalısınız")]
        [Display(Name="Kategori Adı")]
        public string Name { get; set; }
        public List<Product> Products { get; internal set; }
    }
}
