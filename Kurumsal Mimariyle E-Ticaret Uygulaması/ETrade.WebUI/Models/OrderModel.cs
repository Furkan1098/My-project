using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.WebUI.Models
{
    public class OrderModel
    {
        [Display(Name = "Ad")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        public string LastName { get; set; }
        [Display(Name = "Adres")]
        public string Address { get; set; }
        [Display(Name ="Şehir")]
        public string City { get; set; }
        [Display(Name = "Telefon")]
        public string Phone { get; set; }

        public string Email { get; set; }
        [Display(Name = "Kart Sahibinin Adı ")]
        public string CardName { get; set; }
        [Display(Name = "Kart Numarası ")]
        public string CardNumber { get; set; }

        [Display(Name = "Son Kullanma Tarihi(Ay) ")]
        public string ExpirationMonth { get; set; }


        [Display(Name = "Son Kullanma Tarihi(Yıl) ")]
        public string ExpirationYear { get; set; }
        public string Cvv { get; set; }
        public CartModel CartModel { get; set; }
    }
}
