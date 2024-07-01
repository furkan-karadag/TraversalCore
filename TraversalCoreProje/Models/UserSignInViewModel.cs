using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
    public class UserSigInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcıadını giriniz")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi giriniz")]

        public string Password { get; set; }
    }
}
