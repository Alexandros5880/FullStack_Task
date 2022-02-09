using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack_Task.Areas.Identity.Models
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }
    }
}
