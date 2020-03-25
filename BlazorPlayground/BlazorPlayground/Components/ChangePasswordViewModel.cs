using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPlayground.Components
{
    //<PasswordClass>
    public class ChangePasswordViewModel
    {
        [Display(Name = "Current password")]
        [Required(ErrorMessage = "You need to enter you old password")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [RegularExpression("([a-z]|[A-Z]|[0-9]|[\\W]){4}[a-zA-Z0-9\\W]{6,16}", ErrorMessage = "You password must be between 10-20 charactes. The password must at least contain: one lower-case character, one upper-case character, one number, and a special character (ie. +-?=@ )")]
        [Display(Name = "New password")]
        [Required(ErrorMessage = "You need to enter a new password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "The password doesn't match, please try again")]
        [Required(AllowEmptyStrings =false, ErrorMessage = "Confirm Password required")]
        [DataType(DataType.Password)]
        [Display(Name = "Repeat new password")]
        public string ConfirmPassword { get; set; }
    }
    //</PasswordClass>
}
