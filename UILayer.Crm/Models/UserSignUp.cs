using System.ComponentModel.DataAnnotations;

namespace UILayer.Crm.Models
{
    public class UserSignUp
    {
        [Required(ErrorMessage ="Lütfen ad değerini boş geçmeyin")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyad değerini boş geçmeyin")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen cinsiyet bilgisini boş geçmeyin")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Lütfen mail değerini boş geçmeyin")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Kullanıcı adı değerini boş geçmeyin")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen şifre değerini boş geçmeyin")]
        public string Password{ get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]

        [Compare("Password",ErrorMessage ="şifreler uyuşmuyor lütfen kontrol edin")]
        public string ConfirmPassword { get; set; }
    }
}
