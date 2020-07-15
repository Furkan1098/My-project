using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.WebUI.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email alanı boş bırakılmamalıdır")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email adresiniz hatalı")]
        public string Email { get; set; }

        [Display(Name ="Şifre")]
        [Required(ErrorMessage ="Şifre alanı boş bırakılmamalıdır")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}

