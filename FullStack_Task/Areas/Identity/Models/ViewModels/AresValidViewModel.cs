using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FullStack_Task.Areas.Identity.Models.ViewModels
{
    public class AresValidViewModel
    {
        [Required]
        public ICollection<BusinessArea> BusinessAreas { get; set; }

        [Required]
        public Comment Comment { get; set; }
    }
}
