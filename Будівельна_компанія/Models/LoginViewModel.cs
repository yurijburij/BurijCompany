using System.ComponentModel.DataAnnotations;

namespace Будівельна_компанія.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login")]

        public string UserName { get; set; }

        [Required]
        [UIHint ("Password")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}

