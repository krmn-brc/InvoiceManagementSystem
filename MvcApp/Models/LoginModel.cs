

using System.ComponentModel.DataAnnotations;

namespace MvcApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı veya email adresinizi giriniz!")]
        public string UserNameOrEmail { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz!")]
        public string Password { get; set; }
    }
}