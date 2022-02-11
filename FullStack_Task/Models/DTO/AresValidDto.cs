using FullStack_Task.Areas.Identity.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Models.DTO
{
    public class AresValidDto
    {
        [Required]
        public ICollection<BusinessArea> BusinessAreas { get; set; }

        [Required]
        public Comment Comment { get; set; }
    }
}
