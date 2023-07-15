﻿using System.ComponentModel.DataAnnotations;

namespace AuthenticationAndAuthorization.Models.DTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Must to type into user name")]
        [Display(Name = "User Name")]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Must to type into password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Must to type into email address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "only allow email format")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}
