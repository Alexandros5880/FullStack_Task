using FullStack_Task.Areas.Identity.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Models.Entities
{
    public class Salutation
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public ICollection<ApplicationUser> Users { get; set; }
    }
}
