using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack_Task.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }
        [Required]
        public string Company { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public  bool AcceptTerms { get; set; }
        [NotMapped]
        [Required]
        [StringLength(4)]
        public string CaptchaCode { get; set; }
        // One -- One
        [Required]
        public int SalutationId { get; set; }
        public Salutation Salutation { get; set; }
        // One -- One
        [ForeignKey("CommentId")]
        public Comment Comment { get; set; }
        // One -- One
        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        // Many -- Many
        public virtual ICollection<BusinessArea> BusinessAreas { get; set; }
    }
}
