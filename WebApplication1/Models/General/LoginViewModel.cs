using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.General
{
    public class LoginViewModel
    {
        [Display(Description = "username")]
        [Required(ErrorMessage = "please inpur username")]
        public string Username { get; set; }

        [Display(Description = "username")]
        [Required(ErrorMessage = "please inpur username")]
        public string Password { get; set; }
        public bool RememberMe { get; set; } = true;
        public string ReturnUrl { get; set; }
    }
}
