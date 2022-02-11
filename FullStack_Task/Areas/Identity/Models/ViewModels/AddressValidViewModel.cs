using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Areas.Identity.Models.ViewModels
{
    public class AddressValidViewModel
    {
        [Required]
        public string Country { get; set; } = "";
        [Required]
        public string OfficeName { get; set; }
        [Required]
        public string Street { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string UserId { get; set; }
    }
}
