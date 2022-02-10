using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack_Task.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public  bool AcceptTerms { get; set; }
        [NotMapped]
        [Required]
        [StringLength(4)]
        public string CaptchaCode { get; set; }

        // One -- One
        [ForeignKey("CommentId")]
        public Comment Comment { get; set; }
        // One -- One
        [ForeignKey("AddressId")]
        public virtual Address Address { get; set; }
        // Many -- Many
        public virtual ICollection<BusinessArea> BusinessAreas { get; set; }
    }
}
