﻿using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Areas.Identity.Models.ViewModels
{
    public class PasswordValidViewModel
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(4)]
        public string CaptchaCode { get; set; }

        [Required]
        public bool AcceptTerms { get; set; }
    }
}
