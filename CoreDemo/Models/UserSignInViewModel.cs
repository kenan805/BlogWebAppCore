using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Please input username")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Please input password")]
        public string Password { get; set; }
    }
}
