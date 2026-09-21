using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DocAppoint.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress (ErrorMessage = "Invalid email address")]
        
        public string Email { get; set; }

        [Required (ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Remember Me")]
        public bool RememberMe { get; set; }
    }
}
