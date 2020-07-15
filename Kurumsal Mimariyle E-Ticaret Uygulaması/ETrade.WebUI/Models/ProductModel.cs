using ETrade.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.WebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Display(Name ="Ürünün ismi")]
        [Required(ErrorMessage ="Ürünün ismini giriniz")]
        public string Name { get; set; }


        [Display(Name ="Resim url'si")]
        [Required(ErrorMessage ="Resim bilgisi giriniz")]
        public string ImageUrl { get; set; }

        [Display(Name = "Ürün açıklaması")]
        [Required(ErrorMessage = "Ürün açıklaması minimum 20 karakter ve maksimum 100000 karakter olmalıdır.")]
        [StringLength(100000, MinimumLength = 20, ErrorMessage = "Ürün açıklaması minimum 20 karakter ve maksimum 100000 karakter olmalıdır.")]
        public string Description { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat belirtiniz")]
        [Range(1, 1000000)]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; internal set; }
    }
}
