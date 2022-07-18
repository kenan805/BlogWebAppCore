using System.ComponentModel.DataAnnotations;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Name Surname")]
        [Required(ErrorMessage ="Please input name and surname")]
        public string Fullname { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please input password")]
        public string Password { get; set; }

        [Display(Name = "Password again")]
        [Compare("Password", ErrorMessage = "Passwords do not match!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail address")]
        [Required(ErrorMessage = "Please input mail")]
        public string Mail { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please input username")]
        public string UserName { get; set; }
    }
}
