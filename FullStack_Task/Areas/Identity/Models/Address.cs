using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack_Task.Areas.Identity.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string Country { get; set; }
        public string OfficeName { get; set; }
        public string Street { get; set; }
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
