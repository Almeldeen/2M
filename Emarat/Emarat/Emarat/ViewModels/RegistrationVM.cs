using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.ViewModels
{
    public class RegistrationVM
    {
        [Required(ErrorMessage = "This Filed is required")]
        [EmailAddress(ErrorMessage = "Invalid Mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Filed is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This Filed is required")]
        [MinLength(6, ErrorMessage = "Min len is 6")]
        public string Password { get; set; }
        [Required(ErrorMessage = "This Filed is required")]
        [Compare("Password", ErrorMessage = "Password not match")]
        public string ConfirmedPassword { get; set; }
    }
}
