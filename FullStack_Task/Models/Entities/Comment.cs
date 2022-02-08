﻿using FullStack_Task.Areas.Identity.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStack_Task.Models.Entities
{
    public class Comment
    {
        [Key]
        public int ID { get; set; }
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
