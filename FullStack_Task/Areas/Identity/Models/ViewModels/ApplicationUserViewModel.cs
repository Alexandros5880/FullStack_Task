using System.Collections.Generic;

namespace FullStack_Task.Areas.Identity.Models.ViewModels
{
    public class ApplicationUserViewModel
    {
        // Craate Salutation
        public int SalutationId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        // BusinessAreas
        // BusinessAreas
        public int[] BAreas { get; set; }
        public ICollection<BusinessArea> BusinessAreas { get; set; }
        // Create Comment
        public string CommentS { get; set; }
        // Create Address
        public string Country { get; set; } = "";
        public string OfficeName { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Password { get; set; }
        public bool AcceptTerms { get; set; }
    }
}
