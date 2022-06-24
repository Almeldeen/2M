using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Emarat.ViewModels
{
    public class LogInVM
    {
        [Required(ErrorMessage = "This Filed is required")]
        [EmailAddress(ErrorMessage = "Invalid Mail")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This Filed is required")]
        [MinLength(6, ErrorMessage = "Min len is 6")]
        public string Password { get; set; }
        public bool IsSelected { get; set; }
    }
}
