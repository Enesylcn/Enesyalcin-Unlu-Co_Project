using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommerceProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adı Giriniz.")]
        public string UserName{ get; set; }
        [MinLength(8),MaxLength(20),Required(ErrorMessage = "Lütfen Min 8 Max 20 karakterlik Şifre Giriniz.")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Şifreyi Tekrar Giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler Uyusmuyor.")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Lütfen Mail Giriniz.")]
        public string Mail { get; set; }
    }
}
