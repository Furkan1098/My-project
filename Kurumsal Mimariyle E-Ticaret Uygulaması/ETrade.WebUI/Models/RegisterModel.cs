using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ETrade.WebUI.Models
{
    public class RegisterModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage ="Ad ve soyad girmek zorunludur")]
        public string FullName { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı girmek zorunludur")]
        public string UserName { get; set; }


        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre girmek zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre girmek zorunludur")]
        [DataType(DataType.Password)]
        [StringLength(6, ErrorMessage ="Şifreniz en az 6 haneli olmalıdır")]
        [RegularExpression(@"^((?=.*[a-z])(?=.*[A-Z])(?=.*\d)).+$", ErrorMessage ="Şifreniz en az 6 haneli olmalı rakam, büyük harf, küçük harf ve sembol içermelidir")]
        [Compare("Password",ErrorMessage ="Girdiğiniz şifreler uyuşmamaktadır")]
        public string RePassword { get; set; }

        [Required(ErrorMessage = "Email girmek zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
