﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Calendar.Models
{
    public class Acknowledgement
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        [StringLength(15, MinimumLength = 2), Required]
        public string Team { get; set; }
        [StringLength(500, MinimumLength = 3), Required]
        public string AckMessage { get; set; }

        [Display(Name = "Creation Date"), DisplayFormat(DataFormatString = "{0:MMM d, yyyy h:mm tt}", ApplyFormatInEditMode = false), DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Created By"), StringLength(50)]
        public string CreatedBy { get; set; }
        [Display(Name = "Created By"), StringLength(50)]
        public string CreatedByDisplayName { get; set; }
        [Display(Name = "Last Updated"), DisplayFormat(DataFormatString = "{0:MMM d, yyyy h:mm tt}", ApplyFormatInEditMode = false), DataType(DataType.DateTime)]
        public DateTime UpdatedDate { get; set; }
        [Display(Name = "Updated By"), StringLength(50)]
        public string UpdatedBy { get; set; }
        [Display(Name = "Updated By"), StringLength(50)]
        public string UpdatedByDisplayName { get; set; }

    }
}
