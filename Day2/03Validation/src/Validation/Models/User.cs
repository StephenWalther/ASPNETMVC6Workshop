using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Validation.Models
{
    public class User :IValidatableObject
    {
        [Required(ErrorMessage = "You must enter a username.")]
        //[Remote("ValidateUsername", "UsersController", ErrorMessage="Username already taken.")]
        public string Username { get; set; }

        public string Comments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();

            // validate Comments
            if (!Comments.Contains("good"))
            {
                results.Add(new ValidationResult("Bad comment!", new string[] { "Comments" }));
            }

            return results;
        }
    }
}