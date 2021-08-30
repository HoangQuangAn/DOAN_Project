﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DOAN_Project.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        public string ID { get; set; }

        [Required]
        public string Content { get; set; }
    }
}