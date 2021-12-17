using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate
    {
        [MinLength(10, ErrorMessage = "Must be 10-30 characters")]
        [MaxLength(30, ErrorMessage = "Must be 10-30 characters")]
        public string Fullname { get; set;}

        [Required(ErrorMessage = "Email is required")]
        [MaxLength(30, ErrorMessage = "Can be at most 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set;}

        [Required(ErrorMessage = "Username is required")]
        [MinLength(5, ErrorMessage = "Must be 5-20 characters")]
        [MaxLength(20, ErrorMessage = "Must be 5-20 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Must be 10-50 characters")]
        [MaxLength(50, ErrorMessage = "Must be 10-50 characters")]
        public string Password { get; set; }
    }
}
