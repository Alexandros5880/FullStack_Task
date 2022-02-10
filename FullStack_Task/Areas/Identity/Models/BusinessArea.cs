using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Areas.Identity.Models
{
    public class BusinessArea
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
        public BusinessArea()
        {
            this.Users = new HashSet<ApplicationUser>();
        }
    }
}
