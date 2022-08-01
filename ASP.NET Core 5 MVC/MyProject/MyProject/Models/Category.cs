﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Name")]
        [Required]
        public string CategoryName { get; set; }
        [DisplayName("Display Order")]
        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Display Order for Category must be greater than 0")]
        public int DisplayOrder { get; set; }

    }
}
