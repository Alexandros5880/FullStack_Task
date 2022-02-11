using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Areas.Identity.Models.ViewModels
{
    public class ContactValidViewModel
    {
        [Required]
        public int SalutationId { get; set; }
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



        //public int SalutationId { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public string MiddleName { get; set; }
        //public string Company { get; set; }
        //public string Title { get; set; }
        //public string Email { get; set; }
        //public string ConfirmEmail { get; set; }
        //public string Phone { get; set; }
        //public string Fax { get; set; }
        //public string Mobile { get; set; }

    }
}
