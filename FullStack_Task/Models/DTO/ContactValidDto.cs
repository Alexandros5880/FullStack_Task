using FullStack_Task.Areas.Identity.Models;
using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Models.DTO
{
    public class ContactValidDto
    {
        [Required]
        public Salutation SalutationId { get; set; }
        public Salutation Salutation { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [EmailAddress]
        [Compare("Email", ErrorMessage = "The email and confirmation email do not match.")]
        public string ConfirmEmail { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

    }
}
