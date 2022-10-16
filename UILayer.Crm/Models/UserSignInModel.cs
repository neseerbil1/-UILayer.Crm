using System.ComponentModel.DataAnnotations;

namespace UILayer.Crm.Models
{
    public class UserSignInModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını boş geçmeyin")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi girin")]
        public string Password { get; set; }
    }
}
