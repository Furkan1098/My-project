using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETrade.WebUI.Models
{
    public class ResetPasswordModel
    {
        [Required]
        public string Token { get; set; }

        [Required(ErrorMessage = "Email adresi girmek zorunludur")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre girmek zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

