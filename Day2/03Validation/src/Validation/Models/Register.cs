using System;
using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class Register
    {
        [Required(ErrorMessage ="First name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string LastName { get; set; }

        [CreditCard(ErrorMessage = "Invalid credit card number.")]
        public string CreditCard { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password is required.")]
        public string ConfirmPassword { get; set; }

        [RegularExpression(@"^(\d{3}-?\d{2}-?\d{4}|XXX-XX-XXXX)$", ErrorMessage = "Invalid social security number.")]
        public string SocialSecurityNumber { get; set; }
    }
}