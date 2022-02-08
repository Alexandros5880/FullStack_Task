using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack_Task.Areas.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        [ForeignKey("Salutation")]
        public int SalutationId { get; set; }
        public Salutation Salutation { get; set; }
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
        public ICollection<BusinessArea> BusinessAreas { get; set; }
        [ForeignKey("Comment")]
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
    }
}
