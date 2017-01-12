﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class Project
    {
        public int ID { get; set; }
        [StringLength(5, MinimumLength = 2), Required]
        public string Name { get; set; }
        [StringLength(50, MinimumLength = 3), Required]
        public string Description { get; set; }
        [StringLength(5, MinimumLength = 2), Required]
        public string Administrator { get; set; }
    }
}
